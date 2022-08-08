using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gradebook
{
    public class Book
    {
        public List<double> grades;
        public Book()
        {
            grades = new List<double>();
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
                result += grade;
            }
            result /= grades.Count;

            Console.WriteLine($"The average grade is {result}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

    }
}