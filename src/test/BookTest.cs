using gradebook;

namespace test;

public class BookTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var book = new Book();
        book.AddGrade(23);
        book.AddGrade(45);
        book.AddGrade(67);
        book.AddGrade(89);
        
        // Act
        var result = book.GetStatistics();

        // Assert        

    }   
}