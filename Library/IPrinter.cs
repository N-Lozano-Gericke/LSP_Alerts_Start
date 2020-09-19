using System;

namespace LSPLibrary
{
    public interface IPrinter
    {
        string EventType { get;}
        string EventName { get;}
        void Send();
    }
}
