using gradebook;

namespace test;

public class BookTest
{
    [Fact]
    public void BookCalculatesAnAverageGrade()
    {
        // Arrange
        var book = new Book("Book A");
        book.AddGrade(23);
        book.AddGrade(45);
        book.AddGrade(67);
        book.AddGrade(89);
        
        // Act
        var result = book.GetStatistics();

        // Assert      
        Assert.Equal(23, result.Low);
        Assert.Equal(89, result.High);
        Assert.Equal(56, result.Average);  
        Assert.Equal('D', result.Letter);

    }   

}