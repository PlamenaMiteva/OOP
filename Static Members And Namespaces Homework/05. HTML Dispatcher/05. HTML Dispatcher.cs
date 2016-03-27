using System;
using Models;

class HTMLDispatcher
    {
        static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");
            Console.WriteLine(div.Name);
            Console.WriteLine(div.AddAttribute("id", "page"));
            Console.WriteLine(div.AddAttribute("class", "big"));
            Console.WriteLine(div.AddContent("<p>Hello</p>"));
            Console.WriteLine(div * 2);
        }
    }

