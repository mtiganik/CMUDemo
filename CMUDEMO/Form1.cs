using NationalInstruments.NI4882;
using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;

namespace CMUDEMO
{
    public enum ValueType
    {
        AvgBurstPwCurr,
        PeakBurstPwCurr,
        PowerControlLevel,
        TimingAdvError,
        BurstsOutOfTol,
        PhErrPeakCurrent,
        PhErrPeakAverage,
        PhErrPeakMaxMin,
        PhErrRMSCurrent,
        PhErrRMSAverage,
        PhErrRMSMaxMin,
        FreqErrCurrent,
        FreqErrAverage,
        FreqErrMaxMin,
        AvgBurstPwAvg
    }


    public partial class Form1 : Form
    {


        private bool isSessionOpen = false;

        private Device device;


        // using NationalInstruments.NI4882;
        // private Device device;
        // device = new Device(int deviceIDAddress, (byte)PrimaryAddress, (byte)SecondaryAddress);
        // device.Write(stringToWriteTextBox.Text);
        // stringReadTextBox = device.ReadString();
        // device.Dispose();


        public Form1()
        {
            InitializeComponent();
            secondaryAddressComboBox.Items.Add("None");

            for (int i = 96; i < 126; i++)
            {
                secondaryAddressComboBox.Items.Add(i);
            }
            secondaryAddressComboBox.SelectedIndex = 3;

            setupControlState(isSessionOpen);


        }

        private void setupControlState(bool isSessionOpen)
        {
            primaryAddressNumericUpDown.Enabled = !isSessionOpen;
            secondaryAddressComboBox.Enabled = !isSessionOpen;
            openButton.Enabled = !isSessionOpen;
            closeButton.Enabled = isSessionOpen;
            stringToWriteTextBox.Enabled = isSessionOpen;
            callButton.Enabled = isSessionOpen;
            readButton.Enabled = isSessionOpen;
            beginButton.Enabled = isSessionOpen;
        }


        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int currentSecondaryAddress = 0;
                if (secondaryAddressComboBox.SelectedIndex != 0)
                {
                    currentSecondaryAddress = (int)secondaryAddressComboBox.SelectedItem;
                }
                device = new Device(0, (byte)primaryAddressNumericUpDown.Value, (byte)currentSecondaryAddress);
                setupControlState(true);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            try
            {
                device.Dispose();
                setupControlState(false);
                stringReadTextBox.Text = "";
                stringReadTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            try
            {
                device.Write(ReplaceCommonEscapeSequences(stringToWriteTextBox.Text));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                stringReadTextBox.Text = InsertCommonEscapeSequences(device.ReadString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                readButton.Enabled = false;
            }
        }

        private string ReplaceCommonEscapeSequences(string s)
        {
            return s.Replace("\\n", "\n").Replace("\\r", "\r");
        }

        private string InsertCommonEscapeSequences(string s)
        {
            return s.Replace("\n", "\\n").Replace("\r", "\\r");
        }

        private void stringToWriteTextBox_TextChanged(object sender, EventArgs e)
        {
            readButton.Enabled = true;
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            if (beginButton.Text != "Stopp")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    stringReadTextBox.Text = "Saadan käsklust: \r\n";

                    using (StreamReader sr = File.OpenText("../../CodeToInitializeCMU.txt"))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            stringReadTextBox.Text += s + "\r\n";
                            device.Write(ReplaceCommonEscapeSequences(s));
                        }
                    }

                    device.Write("PROC:SIGN:ACT SON");
                    string outputString = "";
                    string message = "Lülitage telefon Lennujuhtimisrežiimi ja tagasi tavareziimi";

                    while (!outputString.Contains("SYNC"))
                    {
                        MessageBox.Show(message);       // See on viis, kuidas CMU initseerimine ära oodata
                        device.Write("SENS:SIGN:STAT?");
                        outputString = device.ReadString();
                    }
                    outputString = "";
                    while (!outputString.Contains("CEST"))
                    {
                        device.Write("PROC:SIGN:ACT MTC");
                        device.Write("SENS:SIGN:STAT?");
                        outputString = device.ReadString();
                        if (outputString.Contains("ALER"))
                        {
                            MessageBox.Show("Võtke telefon vastu");
                        }
                    }

                    // Mõõtmiste funktsioonid. Need algavad siin ja jätkuvad timer1 loop'is
                    device.Write("INIT:POW:MPR;*OPC?");
                    Thread.Sleep(2000);                     // Aeg, et funktsioon jookseks CMU's lõpuni
                    device.Write("FETC:POW:MPR:STAT?;*OPC?");
                    outputString = device.ReadString();
                    if (outputString.Contains("RDY"))
                    {
                        timer1.Start();                     // Mõõtmised hakkavad jooksma
                        stringReadTextBox.Text = "";
                    }
                    else
                    {
                        stringReadTextBox.Text += "Ei saanud initseerida võimsuse mõõtmist";
                    }
                    beginButton.Text = "Stopp";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    setupControlState(true);
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                timer1.Stop();
                beginButton.Text = "Alusta Testi";

            }
        }

        // Funktsioon timer1_Tick Power/mod järjepidevaks mõõtmiseks
        // Kood, mida CMU'sse mõõtmisteks peab järjest andma, peaks olema järjestuses
        // INIT:POW:MPR;*OPC?
        // FETC:POW:MPR:STAT?
        // FETC:POW:MPR?
        // Aga kuna esimene käsk võtab kaua aega, siis see on pandud loopi viimasena
        private void timer1_Tick(object sender, EventArgs e)
        {
            device.Write("FETC:POW:MPR:STAT?");
            if (device.ReadString().Contains("RDY"))
            {
                stringReadTextBox.Text = "";
                device.Write("FETC:POW:MPR?");
                printResult(device.ReadString());
            }
            device.Write("INIT:POW:MPR;*OPC?");
        }


        // Funktsioon mõõtetulemuste ekraanile kuvamiseks
        // See on ainult Power/mod mõõtmiste jaoks sobilik. Seda võiks teha üldisemaks  
        public void printResult(string ReadValue)
        {
            Dictionary<ValueType, double> readValues = new Dictionary<ValueType, double>();
            string[] readSplitValues = ReadValue.Split(',');

            int dictKey = 0;
            for (int i = 0; i < readSplitValues.Length; i++)
            {
                string splitValue = readSplitValues[i];
                if (splitValue.Equals("MATC"))
                {
                    continue; // ignore MATC
                }
                // convert string to double
                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR"); // just to simulate french culture
                double d = double.Parse(splitValue, CultureInfo.InvariantCulture);

                readValues[(ValueType)dictKey] = d;
                dictKey++;

            }

            foreach (var pair in readValues)
            {
                stringReadTextBox.Text += pair.Key + " : " + pair.Value + "\r\n";
            }
        }
    }
}

