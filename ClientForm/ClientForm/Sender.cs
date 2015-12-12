using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace ClientForm
{
    class Sender
    {
        int bitRate, bitDepth, deviceID;
        string friendAddress;
        IPEndPoint endPoint;
        UdpClient udpSender;
        WaveIn waveIn;

        // Default Constructor
        public Sender() { }

        // Overloaded Constructor
        public Sender(int bitRate, int bitDepth, int deviceID, string friendAddress)
        {
            this.bitRate = bitRate;
            this.bitDepth = bitDepth;
            this.deviceID = deviceID;
            this.friendAddress = friendAddress;

            udpSender = new UdpClient();
            endPoint = new IPEndPoint(IPAddress.Parse(friendAddress), 6000);
            waveIn = new WaveIn();
        }

        public void InitializeWaveInEvent()
        {
            waveIn.BufferMilliseconds = 50;
            waveIn.DeviceNumber = deviceID;
            waveIn.WaveFormat = new WaveFormat(bitRate, bitDepth, WaveIn.GetCapabilities(deviceID).Channels);
        }

        public void SendVoice()
        {
            InitializeWaveInEvent();
            udpSender.Connect(endPoint);
            waveIn.DataAvailable += sourcestream_DataAvailable;
            waveIn.StartRecording();
            while (true)
            {

            }
        }

        private void sourcestream_DataAvailable(object notUsed, WaveInEventArgs e)
        {
            try
            {
                byte[] buffer = (e.Buffer);
                udpSender.Send(buffer, buffer.Length);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        public void DisconnectVoice()
        {
            udpSender.Close();
        }
    }
}
