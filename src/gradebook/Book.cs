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

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average /= grades.Count;
            return result;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

    }
}