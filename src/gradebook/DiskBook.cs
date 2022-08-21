using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gradebook
{
    public class DiskBook : IBook
    {
        public DiskBook(string name)
        {
            Name = name;
        }

        public string Name {get;set;}

        public event InMemoryBook.GradeAddedDelegate GradeAdded;

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}