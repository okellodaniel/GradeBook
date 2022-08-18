using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gradebook
{
    public class Book
    {
        public List<double> grades;
        public string Name;
        public Book(string name)
        {
            grades = new List<double>();
            this.Name = name;
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            // var i = 0;
            // Do while loop
            // Runs loop at least once
            // do
            // {
            //     result.High = Math.Max(grades[i], result.High);
            //     result.Low = Math.Min(grades[i], result.Low);
            //     result.Average += grades[i];
            //     i++;
            // }
            // while(i < grades.Count);

            // While loop
            // while(i < grades.Count){
            //     result.High = Math.Max(grades[i], result.High);
            //     result.Low = Math.Min(grades[i], result.Low);
            //     result.Average += grades[i];
            //     i++;    
            // }

            // For loop

            for(var i =0; i < grades.Count; i++){
                result.High = Math.Max(grades[i], result.High);
                result.Low = Math.Min(grades[i], result.Low);
                result.Average += grades[i];
            }
               
            result.Average /= grades.Count;
            return result;
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >=0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }

    }
}