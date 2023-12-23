namespace Domain.Users;

public sealed class User : Entity
{
    private User(Guid id, Email email, Name name, DateTime createdOn) : base(id)
    {
        Email = email;
        Name = name;
        CreatedOn = createdOn;
    }

    private User() { }

    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public DateTime CreatedOn { get; private set; }

    public static User Create(Email email, Name name)
    {
        User user = new(Guid.NewGuid(), email, name, DateTime.UtcNow);

        user.RaiseEvent(new UserCreatedDomainEvent(user.Id, user.CreatedOn));

        return user;
    }
}
