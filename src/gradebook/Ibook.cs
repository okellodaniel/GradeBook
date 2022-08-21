using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static gradebook.InMemoryBook;

namespace gradebook
{
    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name {get;set;}
        event GradeAddedDelegate GradeAdded;
    }
}