using System;
using System.IO.Ports;
using EfsTools.Utils;

namespace EfsTools.Qualcomm
{
    internal abstract class HdlcSerial : IDisposable
    {
        private bool _hdlcStart = true;
        private readonly byte[] _readBuffer = new byte[64 * 1024];

        public abstract bool IsOpen { get; }
        public abstract string PortName { get; }
        public bool HdlcStart { get { return _hdlcStart; } set { _hdlcStart = value; } }

        public abstract void Dispose();
        public abstract void Open();
        public abstract void Close();

        protected abstract void WriteRaw(byte[] data);
        protected abstract int ReadRaw(byte[] buffer);

        public void Write(byte[] data)
        {
            var encoded = HdlcEncoder.Encode(data, _hdlcStart);
            WriteRaw(encoded);
        }

        public byte[] Read()
        {
            var read = ReadRaw(_readBuffer);
            var decoded = HdlcEncoder.Decode(_readBuffer, read);
            return decoded;
        }
    }
}