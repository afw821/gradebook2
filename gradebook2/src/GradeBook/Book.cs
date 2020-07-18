using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace gradebook2.src.GradeBook
{
    public class Book
    {
        public Book(string name) //when new keyword used will have to provide a name
        {
            grades = new List<double>();
            Name = name;
        }

        //instance member of class
        public void AddGrade(double grade) //void = not going to return a value
        {
            grades.Add(grade);
        }

        public Statictics GetStatstics()
        {
            Statictics result = new Statictics();

            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);

                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }

        private List<double> grades; //this is a field

        public string Name;
    }
}
