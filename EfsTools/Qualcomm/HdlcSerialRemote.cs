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

        public HdlcSerialRemote(string port, int timeout)
        {
            HdlcStart = false;

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

        protected override void WriteRaw(byte[] data)
        {
            _stream.Write(data, 0, data.Length);
        }

        protected override int ReadRaw(byte[] buffer)
        {
            return _stream.Read(buffer, 0, buffer.Length);
        }
    }
}