namespace Domain;

public interface IFolloweRepository
{
    void InsertAsync(Follower follower);
    Task<bool> IsAlreadyFollowingAsync(Guid userId, Guid followedId, CancellationToken cancellationToken);
}
