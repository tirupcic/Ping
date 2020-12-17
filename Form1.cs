using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            Ping ping = new Ping();
            try
            {
                if (!adressTextBox.Text.Equals(""))
                {
                  
                        PingReply rep = ping.Send(adressTextBox.Text, count * 10000);
                        AddressLabel.Text = rep.Address.ToString();
                        label5.Text = rep.RoundtripTime.ToString();
                        label6.Text = rep.Options.Ttl.ToString();
                        label7.Text = rep.Options.DontFragment.ToString();

                   

                }
                else
                {
                    MessageBox.Show("Address cannot be empty");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        private void stopButton_Click(object sender, EventArgs e)
        { 

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void adressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pingInterval_UpDown_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void pingIntervalabel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }


}
