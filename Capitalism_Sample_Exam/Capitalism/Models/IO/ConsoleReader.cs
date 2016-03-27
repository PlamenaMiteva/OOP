namespace Capitalism.Models.IO
{
    using System;
    using Capitalism.Interfaces;

    public class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}
