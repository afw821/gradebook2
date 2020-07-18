using System;
using System.Collections.Generic;

namespace gradebook2.src.GradeBook
{//class defines a new type
    public class Program
    {
        static void Main(string[] args) //static keyword = not associated with an object instance
        {

            Book book = new Book("Alex's Grade Book"); //parentheses invokes constructor which takes care of initialization
            book.AddGrade(88.7);
            book.AddGrade(90.5);
            book.AddGrade(99.5);

            Statictics stats = book.GetStatstics();

            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");

        }
    }
}
