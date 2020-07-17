using System;
using System.Collections.Generic;
using System.Text;

namespace gradebook2.src.GradeBook
{
    public class Book
    {
        public Book(string name) //when new keyword used will have to provide a name
        {
            grades = new List<double>();
            this.name = name;
        }

        private List<double> grades; //this is a field

        private string name;
        //instance member of class
        public void AddGrade(double grade) //void = not going to return a value
        {
            grades.Add(grade);
        }

        public void ShowStatstics()
        {
            double result = 0.0;
            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;

            foreach (double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);

                result += number;
            }

            result /= grades.Count;

            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"The highest grade is {highGrade:N1}");
            Console.WriteLine($"The lowest grade is {lowGrade:N1}");
        }
    }
}
