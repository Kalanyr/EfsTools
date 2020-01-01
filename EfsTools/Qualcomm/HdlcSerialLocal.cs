using System;
using System.IO.Ports;
using EfsTools.Utils;

namespace EfsTools.Qualcomm
{
    internal class HdlcSerialLocal : HdlcSerial
    {
        private readonly SerialPort _port;

        private readonly byte[] _readBuffer = new byte[64 * 1024];

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

        private void WriteRaw(byte[] data)
        {
            _port.Write(data, 0, data.Length);
        }

        public override void Write(byte[] data)
        {
            var encoded = HdlcEncoder.Encode(data);
            WriteRaw(encoded);
        }

        private int ReadRaw(byte[] buffer)
        {
            return _port.Read(buffer, 0, buffer.Length);
        }

        public override byte[] Read()
        {
            var read = ReadRaw(_readBuffer);
            var decoded = HdlcEncoder.Decode(_readBuffer, read);
            return decoded;
        }
    }
}