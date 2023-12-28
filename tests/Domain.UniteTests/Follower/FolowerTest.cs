using Domain.Users;

namespace Domain.UniteTests;

public class FollowerTests
{
    [Fact]
    public void Create_Should_ReturnUser_WhenNameIsValid()
    {
        //Arrange
        Name name = new("gecapo");
        Email email = new("gecapo@gmail.com");

        //Act
        User user = User.Create(email, name);

        //Asert
        Assert.NotNull(user);
    }
}
