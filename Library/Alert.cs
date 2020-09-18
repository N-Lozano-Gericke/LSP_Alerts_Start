using System;
/*
No implementa polimorfismo porque tiene entrada unica y la clase se encarga en realizar la operacion
No implementa el LSP porque no utiliza polimorfismo
*/
namespace LSPLibrary
{
    public class Alert
    {
        public void Send(string type, string text)
        {
            if (type == "trello")
            {
                new TrelloCardCreator().CreateCard(text);
            }
            else if (type == "text") 
            {
                Console.WriteLine(text);
            }
        }
    }
}