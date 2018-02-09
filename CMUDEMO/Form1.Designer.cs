namespace CMUDEMO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stringToWriteTextBox = new System.Windows.Forms.TextBox();
            this.callButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrimaryAddressLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.primaryAddressNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondaryAddressComboBox = new System.Windows.Forms.ComboBox();
            this.openButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.stringReadTextBox = new System.Windows.Forms.TextBox();
            this.currentCommandLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.primaryAddressNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CMU200 kommunikatsioonitester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kirjuta kood CMUsse";
            // 
            // stringToWriteTextBox
            // 
            this.stringToWriteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.stringToWriteTextBox.Location = new System.Drawing.Point(27, 198);
            this.stringToWriteTextBox.Multiline = true;
            this.stringToWriteTextBox.Name = "stringToWriteTextBox";
            this.stringToWriteTextBox.Size = new System.Drawing.Size(397, 24);
            this.stringToWriteTextBox.TabIndex = 2;
            this.stringToWriteTextBox.Text = "*IDN?";
            this.stringToWriteTextBox.TextChanged += new System.EventHandler(this.stringToWriteTextBox_TextChanged);
            // 
            // callButton
            // 
            this.callButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.callButton.Location = new System.Drawing.Point(231, 228);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(97, 33);
            this.callButton.TabIndex = 3;
            this.callButton.Text = "Kirjuta";
            this.callButton.UseMnemonic = false;
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CMU vastus:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Proovime ühendust seadmega, mille aadress on:";
            // 
            // PrimaryAddressLabel
            // 
            this.PrimaryAddressLabel.AutoSize = true;
            this.PrimaryAddressLabel.Location = new System.Drawing.Point(51, 81);
            this.PrimaryAddressLabel.Name = "PrimaryAddressLabel";
            this.PrimaryAddressLabel.Size = new System.Drawing.Size(85, 13);
            this.PrimaryAddressLabel.TabIndex = 7;
            this.PrimaryAddressLabel.Text = "Primary Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Secondary Address:";
            // 
            // primaryAddressNumericUpDown
            // 
            this.primaryAddressNumericUpDown.Location = new System.Drawing.Point(142, 79);
            this.primaryAddressNumericUpDown.Name = "primaryAddressNumericUpDown";
            this.primaryAddressNumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.primaryAddressNumericUpDown.TabIndex = 9;
            this.primaryAddressNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // secondaryAddressComboBox
            // 
            this.secondaryAddressComboBox.FormattingEnabled = true;
            this.secondaryAddressComboBox.Location = new System.Drawing.Point(141, 103);
            this.secondaryAddressComboBox.Name = "secondaryAddressComboBox";
            this.secondaryAddressComboBox.Size = new System.Drawing.Size(55, 21);
            this.secondaryAddressComboBox.TabIndex = 10;
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.openButton.Location = new System.Drawing.Point(33, 133);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(101, 31);
            this.openButton.TabIndex = 11;
            this.openButton.Text = "Ava kanal";
            this.openButton.UseCompatibleTextRendering = true;
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.closeButton.Location = new System.Drawing.Point(161, 129);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(91, 30);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Sulge kanal";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // readButton
            // 
            this.readButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.readButton.Location = new System.Drawing.Point(333, 228);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(91, 33);
            this.readButton.TabIndex = 13;
            this.readButton.Text = "Loe";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.beginButton.Location = new System.Drawing.Point(27, 230);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(198, 32);
            this.beginButton.TabIndex = 14;
            this.beginButton.Text = "Alusta Testi";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // stringReadTextBox
            // 
            this.stringReadTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.stringReadTextBox.Location = new System.Drawing.Point(22, 291);
            this.stringReadTextBox.Multiline = true;
            this.stringReadTextBox.Name = "stringReadTextBox";
            this.stringReadTextBox.ReadOnly = true;
            this.stringReadTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stringReadTextBox.Size = new System.Drawing.Size(402, 231);
            this.stringReadTextBox.TabIndex = 17;
            // 
            // currentCommandLabel
            // 
            this.currentCommandLabel.AutoSize = true;
            this.currentCommandLabel.Location = new System.Drawing.Point(318, 103);
            this.currentCommandLabel.Name = "currentCommandLabel";
            this.currentCommandLabel.Size = new System.Drawing.Size(10, 13);
            this.currentCommandLabel.TabIndex = 18;
            this.currentCommandLabel.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 569);
            this.Controls.Add(this.currentCommandLabel);
            this.Controls.Add(this.stringReadTextBox);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.secondaryAddressComboBox);
            this.Controls.Add(this.primaryAddressNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrimaryAddressLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.stringToWriteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.primaryAddressNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stringToWriteTextBox;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PrimaryAddressLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown primaryAddressNumericUpDown;
        private System.Windows.Forms.ComboBox secondaryAddressComboBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.TextBox stringReadTextBox;
        private System.Windows.Forms.Label currentCommandLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

