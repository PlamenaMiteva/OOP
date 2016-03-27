namespace Galactic_GPS
{
    using System;
    using Galactic_GPS.Models;

    class Program
    {
        static void Main()
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);

            //this should throw an exception
            //Location venus = new Location(200, -89, Planet.Venus);
            //Console.WriteLine(venus);
        }
    }
}
