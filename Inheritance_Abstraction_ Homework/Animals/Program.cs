namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Animals.Models;

    class Program
    {
        static void Main()
        {
            var animals = new List<Animal>
            {
                new Cat("Pussy", 2, Gender.Female),
                new Cat("Murro", 3, Gender.Male),
                new Dog("Sharo", 5, Gender.Male),
                new Dog("Bob", 2, Gender.Male),
                new Frog("Kikeritca", 6, Gender.Female),
                new Frog("Froggy", 4, Gender.Male),
                new Kitten("Angel", 1),
                new Kitten("Alex", 8),
                new Tomcat("Charlie", 6),
                new Tomcat("Gandalf", 3)
            };
            var animalGroups = animals.GroupBy(a => a.GetType()).Select(group => new
            {
                Name = group.Key.Name,
                AvgAge = group.Average(a => a.Age)
            });

            foreach (var animalGroup in animalGroups)
            {
                Console.WriteLine(animalGroup.Name + " - " + animalGroup.AvgAge);
            }
        }
    }
}
