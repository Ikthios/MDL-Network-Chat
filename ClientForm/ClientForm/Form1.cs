using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.Net;
using System.Net.Sockets;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Cmb_BitDepth.SelectedIndex = 0;
            Cmb_BitRate.SelectedIndex = 7;

            GetInputDevices();
        }

        private void Btn_CallFriend_Click(object sender, EventArgs e)
        {
            bool call = false;

            if (Txt_FriendAddress.Text.Equals(null))
            {
                MessageBox.Show("Enter an IP address for the friend.");
            }
            else if(call == false)
            {
                try
                {
                    int bitRate = int.Parse(Cmb_BitRate.SelectedText);
                    int bitDepth = int.Parse(Cmb_BitDepth.SelectedText);
                    int deviceID = Cmb_InputDevices.SelectedIndex;
                    string friendAddress = Txt_FriendAddress.Text;

                    Sender send = new Sender(bitRate, bitDepth, deviceID, friendAddress);
                    Receiver receive = new Receiver(bitRate, bitDepth, deviceID);

                    receive.StartListening();
                    send.SendVoice();

                    Btn_CallFriend.BackColor = Color.Green;
                    Btn_CallFriend.Text = "Calling Friend.";

                    call = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (call)
            {
                Sender send = new Sender();
                Receiver receive = new Receiver();

                try
                {
                    receive.StopReceiver();
                    send.DisconnectVoice();

                    Btn_CallFriend.BackColor = Color.Red;
                    Btn_CallFriend.Text = "Disconnected.";

                    call = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void GetInputDevices()
        {
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                var capabilities = WaveIn.GetCapabilities(i);
                Cmb_InputDevices.Items.Add(capabilities.ProductName);
            }

            if (Cmb_InputDevices.Items.Count > 0)
            {
                Cmb_InputDevices.SelectedIndex = 0;
            }
        }

        public string GetIpAddress()
        {
            IPHostEntry host;
            string localIp = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress address in host.AddressList)
            {
                if (address.AddressFamily.ToString() == "InterNetwork")
                {
                    localIp = address.ToString();
                }
            }
            return localIp;
        }
    }
}
