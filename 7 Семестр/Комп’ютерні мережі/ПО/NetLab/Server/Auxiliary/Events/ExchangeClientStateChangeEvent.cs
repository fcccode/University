using System;

namespace Server.Auxiliary
{
    public class ClientStateEvent:EventArgs
    {
        public bool   State
        { get; set; }
    }
}
