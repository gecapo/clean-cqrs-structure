namespace Domain.Users;

public sealed class User : Entity
{
    private User(Guid id, Name name) : base(id)
    {
        Name = name;
    }

    public Name Name { get; private set; }

    public static User Create(Name name)
    {
        User user = new(Guid.NewGuid(), name);

        user.RaiseEvent(new UserCreatedDomainEvent(user.Id));

        return user;
    }
}
