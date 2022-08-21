using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gradebook
{
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
            Name = name;
        }

        public override event InMemoryBook.GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            // Wrapping an IDisposable in a using statement
            // This helps in automatically disposing of the object when the block is exited

            using(var writer = File.AppendText("grades.txt")){
                writer.WriteLine($"{Name} {grade}");
                if(GradeAdded != null){
                    GradeAdded(this, new EventArgs());
                }
            }            

        }

        public override Statistics GetStatistics()
        {
            ;
        }
    }
}