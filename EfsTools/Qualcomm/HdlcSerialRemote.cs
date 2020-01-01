using System;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using EfsTools.Utils;

namespace EfsTools.Qualcomm
{
    internal class HdlcSerialRemote : HdlcSerial
    {
        private readonly string _portName;
        private readonly TcpListener _listener;
        private TcpClient _port;
        private NetworkStream _stream;

        private readonly byte[] _readBuffer = new byte[64 * 1024];

        public HdlcSerialRemote(string port, int timeout)
        {
            _portName = port;
            _listener = new TcpListener(IPAddress.Any, Int32.Parse(port));
            _listener.Start();
        }

        public override bool IsOpen => _port.Connected;
        public override string PortName => _portName;

        public override void Dispose()
        {
            _port?.Dispose();
        }

        public override void Open()
        {
            _port = _listener.AcceptTcpClient();
            Console.WriteLine("Client connected");
            _stream = _port.GetStream();
        }

        public override void Close()
        {
            _port.Close();
        }

        private void WriteRaw(byte[] data)
        {
            _stream.Write(data, 0, data.Length);
        }

        public override void Write(byte[] data)
        {
            var encoded = HdlcEncoder.Encode(data, false);
            WriteRaw(encoded);
        }

        private int ReadRaw(byte[] buffer)
        {
            return _stream.Read(buffer, 0, buffer.Length);
        }

        public override byte[] Read()
        {
            var read = ReadRaw(_readBuffer);
            var decoded = HdlcEncoder.Decode(_readBuffer, read);
            return decoded;
        }
    }
}