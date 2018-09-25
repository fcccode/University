using System;
using System.Net;


namespace Server.Auxiliary
{
    public interface IAPIEvent
    {
        void OnUDPReceive(IPEndPoint remote, byte[] data);
        void OnExceptionCatch(Exception exception);
    }
}
