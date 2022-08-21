using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gradebook
{
    public abstract class Book : NameObject, IBook
    {
        protected Book(string name) : base(name)
        {
        }

        public abstract event InMemoryBook.GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
        
    }
}