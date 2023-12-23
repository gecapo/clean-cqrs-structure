using Domain.Users;

namespace Domain.UniteTests;

public class NameTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void Constructor_Should_ThrowArgumentException_WhenValueIsNotValid(string? value)
    {
        //Arrange
        Name Action() => new(value);

        //Act
        var exception = Record.Exception(Action);

        //Asert
        Assert.NotNull(exception);
        Assert.IsAssignableFrom<ArgumentException>(exception);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("  ")]
    public void Constructor_Should_ThrowArgumentException_WhenValueIsNotValid2(string? value)
    {
        //Arrange
        Name Action() => new(value);

        Assert.ThrowsAny<ArgumentException>(Action);        
    }
}