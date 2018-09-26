using System;

namespace Client.Event
{
    public class ClientStateEvent:EventArgs
    {
        public bool   State
        { get; set; }
    }
}
