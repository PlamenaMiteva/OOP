namespace Capitalism.Models.IO
{
    using System;
    using Capitalism.Interfaces;

    public class ConsoleWriter : IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
