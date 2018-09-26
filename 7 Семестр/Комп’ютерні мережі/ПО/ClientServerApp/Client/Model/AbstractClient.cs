using Client.Auxiliary;
using Client.Event;
using System;
using System.Net;

namespace Client.Model
{
    public abstract class AbstractClient:BindingProperty
    {
       
        public IPEndPoint RemoteEndPoint { get; protected set; }

        private bool _isConnect;
        public bool IsConnect
        {
            get { return _isConnect; }
            set
            {
                _isConnect = value;
                OnPropertyChanged(nameof(IsConnect));
            }
        }

        public event EventHandler<ClientStateEvent> StateChangeEvent;
        public event EventHandler<PackageReceiveEvent> DataReceiveEvent;
        public event EventHandler<PackageReceiveEvent> ErrorEvent;


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
