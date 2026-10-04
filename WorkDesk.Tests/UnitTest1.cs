namespace WorkDesk.Tests;

public class UnitTest1
{
    [Fact]
    public void Addition_ShouldReturnCorrectResult()
    {
        // Arrange
        int a = 10;
        int b = 20;

        // Act
        int result = a + b;

        // Assert
        Assert.Equal(30, result);
    }
}