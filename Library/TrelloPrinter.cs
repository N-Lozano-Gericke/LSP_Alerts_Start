namespace LSPLibrary
{
    public class TrelloPrinter : IPrinter
    {
        public void Send(string type, string text)
        {
            new TrelloCardCreator().CreateCard(text);
        }
    }
}