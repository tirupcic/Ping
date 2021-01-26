namespace PingProject
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
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.optionsTtlLabel = new System.Windows.Forms.Label();
            this.StartPingButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.roundTripTimeLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelStatus = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(128, 12);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(217, 22);
            this.adressTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time interval in seconds";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(176, 65);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // optionsTtlLabel
            // 
            this.optionsTtlLabel.AutoSize = true;
            this.optionsTtlLabel.Location = new System.Drawing.Point(253, 292);
            this.optionsTtlLabel.Name = "optionsTtlLabel";
            this.optionsTtlLabel.Size = new System.Drawing.Size(0, 17);
            this.optionsTtlLabel.TabIndex = 13;
            // 
            // StartPingButton
            // 
            this.StartPingButton.Location = new System.Drawing.Point(12, 131);
            this.StartPingButton.Name = "StartPingButton";
            this.StartPingButton.Size = new System.Drawing.Size(105, 34);
            this.StartPingButton.TabIndex = 0;
            this.StartPingButton.Text = "Start ping ";
            this.StartPingButton.UseVisualStyleBackColor = true;
            this.StartPingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 206);
            this.label3.MaximumSize = new System.Drawing.Size(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 3);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interval value";
            // 
            // roundTripTimeLabel
            // 
            this.roundTripTimeLabel.AutoSize = true;
            this.roundTripTimeLabel.Location = new System.Drawing.Point(253, 206);
            this.roundTripTimeLabel.Name = "roundTripTimeLabel";
            this.roundTripTimeLabel.Size = new System.Drawing.Size(0, 17);
            this.roundTripTimeLabel.TabIndex = 12;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(240, 131);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(105, 34);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Stop ping ";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(253, 250);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(0, 17);
            this.AddressLabel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 250);
            this.label4.MaximumSize = new System.Drawing.Size(1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 170);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time interval";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "RoundTrip time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Time to live";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(346, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 329);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(48, 17);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.Text = "Status";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(253, 329);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(395, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "s";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(549, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "List of pinged address";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(552, 163);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(192, 239);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.optionsTtlLabel);
            this.Controls.Add(this.roundTripTimeLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.StartPingButton);
            this.Name = "Form1";
            this.Text = "Ping ";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label optionsTtlLabel;
        private System.Windows.Forms.Button StartPingButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label roundTripTimeLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listView1;
    }
}

