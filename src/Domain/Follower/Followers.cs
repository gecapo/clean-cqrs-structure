namespace Domain;

public sealed class Follower : Entity
{
    private Follower(Guid userId, Guid followedId, DateTime createdOn)
    {
        UserId = userId;
        FollowedId = followedId;
        CreatedOn = createdOn;
    }

    private Follower() { }

    public Guid UserId { get; private set; }
    public Guid FollowedId { get; private set; }
    public DateTime CreatedOn { get; private set; }

    public static Follower Create(Guid userId, Guid followedId, DateTime createdOn)
    {
        Follower follower = new(userId, followedId, createdOn);
        follower.RaiseEvent(new FollowerCreatedDomainEvent(follower.UserId, follower.UserId, follower.CreatedOn));
        return follower;
    }
}
