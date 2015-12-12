using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.Net;
using System.Net.Sockets;

namespace ClientForm
{
    class Receiver
    {
        int bitRate, bitDepth, deviceID;

        UdpClient udpListener;
        IPEndPoint endPoint;
        WaveOut waveOut;
        WaveIn sourceStream;
        BufferedWaveProvider waveProvider;

        // Default Constructor
        public Receiver() { }

        // Overloaded Constructor
        public Receiver(int bitRate, int bitDepth, int deviceID)
        {
            this.bitRate = bitRate;
            this.bitDepth = bitDepth;
            this.deviceID = deviceID;

            udpListener = new UdpClient();
            endPoint = new IPEndPoint(IPAddress.Any, 6000);
            waveProvider = null;
            sourceStream = null;
            waveOut = new WaveOut();
        }

        public void InitializeStream()
        {
            sourceStream = new WaveIn();
            sourceStream.BufferMilliseconds = 50;
            sourceStream.DeviceNumber = 0;
            sourceStream.WaveFormat = new WaveFormat(bitRate, bitDepth, WaveIn.GetCapabilities(deviceID).Channels);
        }

        public void StartWaveProvider()
        {
            waveProvider = new BufferedWaveProvider(sourceStream.WaveFormat);
            waveOut.Init(waveProvider);
            waveOut.Play();
        }

        public void StartListening()
        {
            InitializeStream();
            StartWaveProvider();
            udpListener.Client.Bind(endPoint);
            while (true)
            {
                byte[] buffer = udpListener.Receive(ref endPoint);
                waveProvider.AddSamples(buffer, 0, buffer.Length);
            }
        }

        public void StopReceiver()
        {
            udpListener.Close();
        }
    }
}
