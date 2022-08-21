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

        public virtual event InMemoryBook.GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public virtual Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}