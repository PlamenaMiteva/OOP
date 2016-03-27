using System;
using System.Collections.Generic;
using System.IO;

namespace _03.Paths.Models
{
    public static class Storage
    {
        private static List<Path> paths;

       static Storage()
        {
           paths = new List<Path>();
        }

       public static IEnumerable<Path> Paths
       {
           get { return paths; }
       }

       private static void SavePath(Path path)
       {
           if (path == null)
           {
               throw new ArgumentNullException("Path cannot be null.");
           }
           paths.Add(path);
       }


       public static void LoadPaths(string filePath)
       {
           if (filePath == null)
           {
               throw new InvalidOperationException("File path cannot be null.");
           }
           
           using (StreamReader reader = new StreamReader(filePath))
           {
               string line;
               while ((line = reader.ReadLine()) != null)
               {
                   SavePath(new Path(line));
               }
           }
       }

       
    }
}
