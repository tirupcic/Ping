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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        bool buttonStop = false;
        int timer = 0;
        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!adressTextBox.Text.Equals(""))
            {
                buttonStop = true;
                listView1.Items.Add(adressTextBox.Text);
            }
            else
            {
                MessageBox.Show("Address cannot be empty");
            }
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            buttonStop = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (buttonStop)
            {
                timer++;
                label12.Text = "" + timer.ToString();
                if (timer % count == 0)
                {
                    startPinging();
                }

            }
            else
            {
                timer = 0;
            }


        }

        public void startPinging()
        {
            count = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            Ping ping = new Ping();
            try
            {

                PingReply rep = ping.Send(adressTextBox.Text, count * 10000);
                if (rep.Status == IPStatus.Success)
                {
               
                
                AddressLabel.Text = rep.Address.ToString();
                roundTripTimeLabel.Text = rep.RoundtripTime.ToString();
                optionsTtlLabel.Text = rep.Options.Ttl.ToString();
                statusLabel.Text = rep.Status.ToString();
                bool isInListView = false;

                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text.Equals(adressTextBox.Text))
                    {
                        isInListView = true;
                    }

                }
                if (!isInListView)
                {
                    listView1.Items.Add(adressTextBox.Text);

                }
                }  else
                    {
                    statusLabel.Text = rep.Status.ToString();
                }
                }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
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


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
