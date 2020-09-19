namespace LSPLibrary
{
    public class TrelloPrinter : IPrinter
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
            new TrelloCardCreator().CreateCard(this.EventName);
        }
    }
}