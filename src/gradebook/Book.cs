using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gradebook
{
    public class InMemoryBook : Book
    {
        // A readonly field is a field that can only be set in the constructor
        public readonly string Category = "Book Lau";

        // Constant
        public const string CATEGORY = "Book Lau";

        public List<double> grades;

        // delegate

        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public override event GradeAddedDelegate GradeAdded;

        // Constructor chaining - the first constructor is called first
        public InMemoryBook(string name) : base(name)
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
        public  GetStatistics GetStatistics()
        {
            var result = new GetStatistics();
            

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

            for(var i=0; i < grades.Count; i++){
                
                result.Add(grades[i]);

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
                
            }

            // done:
            return result;
        }

        // // Method overloading
        // public override void AddGrade(char letter){
        //     switch(letter){
        //         case 'A':
        //             AddGrade(90);
        //             break;
        //         case 'B':
        //             AddGrade(80);
        //             break;
        //         case 'C':
        //             AddGrade(70);
        //             break;
        //         default:
        //             AddGrade(0);
        //             break;
        //     }
        // }

       
        public override void AddGrade(double grade)
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