namespace LSPLibrary
/*
No implementa polimorfismo porque tiene entrada unica y la clase se encarga en realizar la operacion
No implementa el LSP porque no utiliza polimorfismo
*/
{
    public class Event
    {
        public string EventName { get; set; }
        public string EventType { get; set; }

        public void Notify()
        {
            new Alert().Send("text", this.EventName);

            if (this.EventType == "severe")
            {
                new Alert().Send("trello", this.EventName);
            }
        }
    }
}