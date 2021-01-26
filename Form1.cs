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
                Boolean isInList = false;
                
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text.ToString().Equals(adressTextBox.Text.ToString()))
                    {
                        isInList = true;
                    }
                }
                if (!isInList)
                {
                    listView1.Items.Add(adressTextBox.Text.ToString());
                }

            }
            else
            {
                MessageBox.Show("Address cannot be empty");
            }
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            buttonStop = false;
            adressTextBox.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (buttonStop)
            {
                adressTextBox.Enabled = false;
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

                    statusLabel.Text = rep.Status.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
      
    }
}
