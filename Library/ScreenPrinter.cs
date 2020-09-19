using System;

namespace LSPLibrary
{
    public class ScreenPrinter : IPrinter
    {
        private string eventtype;
        private string eventname;
        public string EventType 
        { 
            get
            {
                return this.eventtype;
            } 
            
        }
        public string EventName 
        { 
            get
            {
                return this.eventname;
            } 
            
        }
        public void Send()
        {
            Console.WriteLine(this.EventName);
        }
    }
}