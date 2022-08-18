using gradebook;

namespace test;

public class TypeTest
{
    [Fact]
    public void CSahrpCanPassByRef()
    {
        var book1 = GetBook("Book 1");
        test1method(ref book1, "New Name");

        Assert.Equal("New Name", book1.Name);        
    }

    private void test1method(ref Book book, string name)
    {
        book = new Book(name);
    }

    [Fact]
    public void CSharpIsPassedByValue()
    {
        var book1 = GetBook("Book 1");
        GetBookSetName(book1, "New Name");

        Assert.Equal("Book 1", book1.Name);        
    }

    private void GetBookSetName(Book book, string name)
    {
        book = new Book(name);
    }


    [Fact]
    public void CanSetNameFromeReference()
    {
        var book1 = GetBook("Book 1");
        SetName(book1, "New Name");

        Assert.Equal("New Name", book1.Name);        
    }

    private void SetName(Book book, string name)
    {
        book.Name = name;
    }

    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
        // Arrange
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");
        // Act
       

        // Assert      
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);

    }

    [Fact]
      public void TwoVarsCanReferenceSameObject()
    {
        // Arrange
        var book1 = GetBook("Book 1");
        var book2 = book1;
        // Act
       

        // Assert      
        // Assert.Equal("Book 1", book1.Name);
        // Assert.Equal("Book 1", book2.Name);

        Assert.Same(book1, book2);
        Assert.True(Object.ReferenceEquals(book1,book2));

    }

    Book GetBook(string name)
    {
        return new Book(name);
    }

    // Value Types

    [Fact]

    public void Test1()
    {
        var x = GetInt();
        SetInt(ref x);

        Assert.Equal(42,x);
    }

    private void SetInt(ref int x)
    {
        x = 42;
    }

    private int GetInt()
    {
        return 3;
    }

    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
        string name = "Daniel";
        name = MakeUpperCase(name);

        Assert.Equal("DANIEL", name);
    }

    private string MakeUpperCase(string P)
    {
        return P.ToUpper();
    }
}