namespace Inheritance_Exercise
{
    using System;
    using Inheritance_Exercise.Models;

    class BookShop
    {
        static void Main()
        {
            var book = new Book("Pod igoto", "Ivan Vazov", 12.87);
            Console.WriteLine(book);

            var goledenEditionBook = new GoldenEditionBook("Algoritms", "Svetlin Nakov", 20.67);
            Console.WriteLine(goledenEditionBook);
        }
    }
}
