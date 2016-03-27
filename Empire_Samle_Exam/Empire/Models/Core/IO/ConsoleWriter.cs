using System;

namespace Empire.Models.Core.IO
{
    using Empire.Models.Interfaces;

    public class ConsoleWriter:IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
