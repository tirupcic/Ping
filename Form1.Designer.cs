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
            this.StartPingButton = new System.Windows.Forms.Button();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pingInterval_UpDown = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.intervalValue = new System.Windows.Forms.Label();
            this.pingIntervalabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartPingButton
            // 
            this.StartPingButton.Location = new System.Drawing.Point(12, 142);
            this.StartPingButton.Name = "StartPingButton";
            this.StartPingButton.Size = new System.Drawing.Size(105, 34);
            this.StartPingButton.TabIndex = 0;
            this.StartPingButton.Text = "Start ping ";
            this.StartPingButton.UseVisualStyleBackColor = true;
            this.StartPingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(128, 12);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(217, 22);
            this.adressTextBox.TabIndex = 1;
            this.adressTextBox.TextChanged += new System.EventHandler(this.adressTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time interval";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pingInterval_UpDown
            // 
            this.pingInterval_UpDown.Location = new System.Drawing.Point(128, 72);
            this.pingInterval_UpDown.Name = "pingInterval_UpDown";
            this.pingInterval_UpDown.Size = new System.Drawing.Size(217, 22);
            this.pingInterval_UpDown.TabIndex = 4;
            this.pingInterval_UpDown.Text = "Ping interval";
            this.pingInterval_UpDown.SelectedItemChanged += new System.EventHandler(this.pingInterval_UpDown_SelectedItemChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 217);
            this.label3.MaximumSize = new System.Drawing.Size(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 3);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interval value";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 261);
            this.label4.MaximumSize = new System.Drawing.Size(1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 170);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time interval";
            // 
            // intervalValue
            // 
            this.intervalValue.AutoSize = true;
            this.intervalValue.Location = new System.Drawing.Point(12, 261);
            this.intervalValue.Name = "intervalValue";
            this.intervalValue.Size = new System.Drawing.Size(124, 17);
            this.intervalValue.TabIndex = 7;
            this.intervalValue.Text = "Ping interval value";
            this.intervalValue.Click += new System.EventHandler(this.label5_Click);
            // 
            // pingIntervalabel
            // 
            this.pingIntervalabel.AutoSize = true;
            this.pingIntervalabel.Location = new System.Drawing.Point(149, 217);
            this.pingIntervalabel.Name = "pingIntervalabel";
            this.pingIntervalabel.Size = new System.Drawing.Size(86, 17);
            this.pingIntervalabel.TabIndex = 8;
            this.pingIntervalabel.Text = "Ping interval";
            this.pingIntervalabel.Click += new System.EventHandler(this.pingIntervalabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.pingIntervalabel);
            this.Controls.Add(this.intervalValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pingInterval_UpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.StartPingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartPingButton;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown pingInterval_UpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label intervalValue;
        private System.Windows.Forms.Label pingIntervalabel;
    }
}

