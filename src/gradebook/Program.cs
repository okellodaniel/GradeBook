// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using gradebook;

// var book = new InMemoryBook("Daniels Script Book");
var book = new DiskBook("Daniels Script Book");

// Handling the GradeAdded event
book.GradeAdded += OnGradeAdded;
book.GradeAdded += OnGradeAdded;
book.GradeAdded -= OnGradeAdded;

EnterGrades(book);

book.AddGrade(77.5);
book.AddGrade(77.5);
book.AddGrade(88.5);
book.AddGrade(99.5);
book.AddGrade(4.1);

var stats = book.GetStatistics();

Console.WriteLine(book.Name);
Console.WriteLine($"The average is { stats.Average }");
Console.WriteLine($"The highest is { stats.High }");
Console.WriteLine($"The lowest is { stats.Low }");
Console.WriteLine($"The letter grade is { stats.Letter }");
Console.WriteLine($"The Constant category is { InMemoryBook.CATEGORY }");
// Console.WriteLine($"The readonly category is { book.Category }");


static void OnGradeAdded(object sender, EventArgs e)
{
    Console.WriteLine("A grade was added");
}

static void EnterGrades(DiskBook book)
{
    try
    {

        while (true)
        {
            Console.WriteLine("Enter a grade or q to quit");
            var input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }
            else
            {
                var grade = double.Parse(input);
                book.AddGrade(grade);
                book.AddGrade('A');
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("** Processing complete **");
    }
}