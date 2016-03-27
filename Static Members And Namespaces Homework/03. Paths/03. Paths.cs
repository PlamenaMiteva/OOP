namespace _03.Paths
{
    using System;
    using Models;

    class Paths
    {
        static void Main()
        {
            Storage.LoadPaths(@"../../points.txt");
            foreach (var path in Storage.Paths)
            {
                Console.WriteLine(path.Name);
            }
        }
    }
}
