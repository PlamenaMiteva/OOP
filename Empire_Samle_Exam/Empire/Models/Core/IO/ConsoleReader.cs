namespace Empire.Models.Core.IO
{
    using System;
    using Empire.Models.Interfaces;

    public class ConsoleReader: IInputReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();
            return input;
        }
    }
}
