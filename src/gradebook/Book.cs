using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gradebook
{
    public class Book : NameObject
    {
        // A readonly field is a field that can only be set in the constructor
        public readonly string Category = "Book Lau";

        // Constant
        public const string CATEGORY = "Book Lau";

        public List<double> grades;

        // delegate

        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;

        // Constructor chaining - the first constructor is called first
        public Book(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        // Contructor overloads allow you to create multiple constructors with different parameters
        // public Book(string name, string category)
        // {
        //     grades = new List<double>();
        //     Name = name;
        //     Category = category;
        // }
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

                // if(grades[i] == 42.1){
                //     // Break statement - breaks out of loop
                //     break;
                // }

                // if(grades[i] > 42.1){
                //     // Continue statement - skips current iteration of loop
                //     continue;
                // }

                // if(grades[i] == 42.1){
                //     // Goto statement - jumps to a label
                //     goto done;
                // }
                result.High = Math.Max(grades[i], result.High);
                result.Low = Math.Min(grades[i], result.Low);
                result.Average += grades[i];
            }
            result.Average /= grades.Count;

            switch(result.Average){
                case var d when d >=90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >=80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >=70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >=40.0 && d <= 69.9:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            // done:
            return result;
        }

        // Method overloading
        public void AddGrade(char letter){
            switch(letter){
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

       
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >=0)
            {
                grades.Add(grade);

                if(GradeAdded != null){
                    GradeAdded(this,new EventArgs());
                }
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }

    }
}