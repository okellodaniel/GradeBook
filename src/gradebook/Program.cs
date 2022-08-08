// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using gradebook;

var book = new Book();

book.AddGrade(77.5);
book.AddGrade(77.5);
book.AddGrade(88.5);
book.AddGrade(99.5);
book.AddGrade(4.1);

book.ShowStatistics();



