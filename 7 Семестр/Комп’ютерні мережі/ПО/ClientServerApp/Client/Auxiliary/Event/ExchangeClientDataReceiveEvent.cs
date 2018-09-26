using System;
using System.Net;

namespace Client.Event
{
    public class PackageReceiveEvent : EventArgs
    {
        public IPEndPoint RemotePoint { get; private set; }
        public byte[] Data { get; private set; }
        public PackageReceiveEvent(byte[] data, IPEndPoint endpoint )
        {
            Data = data;
            RemotePoint = endpoint;
        }
        public PackageReceiveEvent(){ }
    }
}
