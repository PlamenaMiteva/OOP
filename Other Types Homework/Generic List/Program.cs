using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic_List.Models;

namespace Generic_List
{
    class Program
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(4);
            list.Add(34);
            list.Add(274);
            list.Add(-5);
            Console.WriteLine(list.ToString());
            list.Insert(24, 2);
            Console.WriteLine(list.ToString());
            list.Remove(3);
            Console.WriteLine(list.ToString());
            Console.WriteLine(string.Format("Element at position 0: {0}", list[0]));

            Console.WriteLine(string.Format("Max number: {0}", list.Max()));

            Console.WriteLine(string.Format("Min number: {0}",list.Min()));

            Console.WriteLine(string.Format("-5 is at position# {0}",list.Find(-5)));

            Console.WriteLine(list.Contains(34));

            Console.WriteLine(list.Contains(5));
        }
    }
}
