using System;
using System.IO.Ports;
using EfsTools.Utils;

namespace EfsTools.Qualcomm
{
    internal abstract class HdlcSerial : IDisposable
    {
        public abstract bool IsOpen { get; }
        public abstract string PortName { get; }

        public abstract void Dispose();
        public abstract void Open();
        public abstract void Close();
        public abstract void Write(byte[] data);
        public abstract byte[] Read();
    }
}