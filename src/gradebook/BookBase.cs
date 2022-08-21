using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gradebook
{
    public abstract class Book : NameObject
    {
        protected Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
        
    }
}