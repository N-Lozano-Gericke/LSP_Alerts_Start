using System;

namespace LSPLibrary
{
    public class ScreenPrinter : IPrinter
    {
        public void Send(string type, string text)
        {
            Console.WriteLine(text);
        }
    }
}