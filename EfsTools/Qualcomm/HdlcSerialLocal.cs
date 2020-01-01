using System;
using System.IO.Ports;
using EfsTools.Utils;

namespace EfsTools.Qualcomm
{
    internal class HdlcSerialLocal : HdlcSerial
    {
        private readonly SerialPort _port;

        public HdlcSerialLocal(string port, int baudrate, int timeout)
        {
            _port = new SerialPort(port, baudrate) {ReadTimeout = timeout};
        }

        public override bool IsOpen => _port.IsOpen;
        public override string PortName => _port.PortName;

        public override void Dispose()
        {
            _port?.Dispose();
        }

        public override void Open()
        {
            _port.Open();
        }

        public override void Close()
        {
            _port.Close();
        }

        protected override void WriteRaw(byte[] data)
        {
            _port.Write(data, 0, data.Length);
        }

        protected override int ReadRaw(byte[] buffer)
        {
            return _port.Read(buffer, 0, buffer.Length);
        }
    }
}