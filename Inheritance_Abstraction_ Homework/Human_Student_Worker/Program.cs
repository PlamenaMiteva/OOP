using System;
using System.Collections.Generic;
using System.Linq;
using Human_Student_Worker.Models;

namespace Human_Student_Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student("Ivan", "Petrov", "amcdf12345"),
                new Student("Maria", "Ignatova", "abcuf12346"),
                new Student("Anton", "Trayanov", "abpdf12347"),
                new Student("Pavel", "Mitev", "abcdl12348"),
                new Student("Plamen", "Georgiev", "sbcdf12349")
            };

            var orderedStudents = students.OrderBy(s => s.FacultyNumber);
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.ToString());
            }

            var workers = new List<Worker>
            {
                new Worker("Ivaylo", "Matev", 1886.99m, 12.4),
                new Worker("Tanya", "Asenova", 2966.77m, 15.6),
                new Worker("Galina", "Mincheva", 2893m, 10.2),
                new Worker("Georgi", "Lulov", 3904.57m, 6.4),
                new Worker("Lilly", "Boneva", 7098.88m, 1.3)
            };
            var orderedWorkers = workers.OrderByDescending(w => w.MoneyPerHour);

            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker.ToString());
            }

            var humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var orderedHumans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);

            foreach (var human in orderedHumans)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}

