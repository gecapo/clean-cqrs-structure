using Domain.Users;

namespace Domain.UniteTests;

public class UserTests
{
    [Fact]
    public void Create_Should_ReturnUser_WhenNameIsValid()
    {
        //Arrange
        Name name = new("gecapo");

        //Act
        User user = User.Create(name);

        //Asert
        Assert.NotNull(user);
    }

    [Fact]
    public void Create_Should_RaiseUserCreatedDomainEvent_WhenNameIsValid()
    {
        //Arrange
        Name name = new("gecapo");

        //Act
        User user = User.Create(name);

        //Asert
        Assert.Single(user.DomainEvents);
        Assert.All(user.DomainEvents, item => Assert.IsType<UserCreatedDomainEvent>(item));
    }
}
