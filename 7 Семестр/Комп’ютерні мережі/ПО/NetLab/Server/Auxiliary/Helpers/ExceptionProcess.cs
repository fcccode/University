using AdapterAPI.Enums;
using System;

namespace Server.Auxiliary
{
    [Serializable]
    public sealed class ExceptionProcess 
    {
        private static volatile ExceptionProcess instance;
        private static object syncRoot = new Object();
        public static ExceptionProcess Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ExceptionProcess();
                    }
                }
                return instance;
            }
        }

        public string GlobalScope { get; private set; }
        public string LocalScope { get; private set; }
        public string ShowMessage { get; private set; }
        public NotifyMessageType ExceptionType { get; private set; }

        private ExceptionProcess(){}
        public void ThrowException(string gs, string ls, string message, NotifyMessageType type)
        {
            GlobalScope = gs;
            LocalScope = ls;
            ShowMessage = message;
            ExceptionType = type;
            Exception exception = new Exception();
            exception.Data["NOTIFY"] = Instance;
            throw exception;
        }

    }
}