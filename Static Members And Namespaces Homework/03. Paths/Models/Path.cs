using System;

namespace _03.Paths.Models
{
   public class Path
    {
       private string name;

       public Path(string name)
        {
            this.Name = name;
        }

       public string Name
       {
           get { return this.name; }
           set {
               if (String.IsNullOrWhiteSpace(value))
               {
                   throw  new ArgumentNullException("Path cannot be null or whitespace");
               }
               this.name = value; }
       }


    }
}
