using System;
using System.Collections.Generic;
using System.Linq;
using Models;

class PCCatalogue
    {
        static void Main()
        {
            Computer comp = new Computer("Toshiba");
            Component c1= new Component("motherboard", 100.89m);
            Component c2 = new Component("mouse", 45.56m);
            Component c3 = new Component("graphic card", 453.65m);
            comp.AddComponent(c1);
            comp.AddComponent(c2);
            comp.AddComponent(c3);


            Computer comp2 = new Computer("HP");
            Component c4 = new Component("motherboard", 545.01m);
            Component c5 = new Component("mouse", 54.71m);
            Component c6 = new Component("graphic card", 369.90m);
            comp2.AddComponent(c4);
            comp2.AddComponent(c5);
            comp2.AddComponent(c6);


            Computer comp3 = new Computer("Lenovo");
            Component c7 = new Component("motherboard", 546.89m);
            Component c8 = new Component("mouse", 28.08m);
            Component c9 = new Component("graphic card", 540.77m);
            comp3.AddComponent(c7);
            comp3.AddComponent(c8);
            comp3.AddComponent(c9);
            

            List<Computer>result=new List<Computer>();
            result.Add(comp);
            result.Add(comp2);
            result.Add(comp3);
            var computers = result.OrderBy(c => c.ComputerPrice).ToList();

            foreach (var computer in computers)
            {
                Console.WriteLine(computer);
                Console.WriteLine();
            }
        }
    }

