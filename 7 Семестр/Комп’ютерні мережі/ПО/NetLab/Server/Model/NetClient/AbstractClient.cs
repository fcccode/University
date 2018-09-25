using Server.Auxiliary;
using System;
using System.Net;

namespace Server.Model
{
    public abstract class AbstractClient
    {
       
        public IPEndPoint RemoteEndPoint
        { get; protected set; }
        public bool IsConnect
        { get; protected set; }

        public event EventHandler<ClientStateEvent> StateChangeEvent;
        public event EventHandler<PackageReceiveEvent> DataReceiveEvent;
        public event EventHandler<PackageReceiveEvent> ErrorEvent;

        public abstract void Connect(IPEndPoint remotePoint);
        public abstract void Disconnect();
        public abstract void Transmit(byte[] data);

        protected virtual void OnStateChanged(bool state)
        {
            IsConnect = state;
            StateChangeEvent?.Invoke(this, new ClientStateEvent { State = IsConnect});
        }
        protected virtual void OnDataReceive(byte[] data)
        {
            DataReceiveEvent?.Invoke(this, new PackageReceiveEvent (data, RemoteEndPoint));
        }
        protected virtual void OnError()
        {
            ErrorEvent?.Invoke(this, null);
        }
    }
}
