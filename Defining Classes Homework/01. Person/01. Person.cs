using System;
using Models;

class MainPerson
{
    static void Main()
    {

        Console.Write("Enter student's name: ");
        string studentName = Console.ReadLine();
        Console.Write("Enter student's age: ");
        int studentAge = int.Parse(Console.ReadLine());
        Console.Write("Enter student's email: ");
        string studentEmail = Console.ReadLine();
        try
        {
            Person student = new Person(studentName, studentAge, studentEmail);
            Console.WriteLine("Hello, {0}!", student.Name);
            Console.WriteLine(student);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Cannot create student object: " + ex);
        }

    }
}

