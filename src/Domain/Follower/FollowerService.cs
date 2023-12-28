using Domain.Users;

namespace Domain;

public sealed class FollowerService
{
    private readonly IFolloweRepository _followeRepository;

    public FollowerService(IFolloweRepository followeRepository)
    {
        _followeRepository = followeRepository;
    }

    public async Task<Result> StartFollowingAsync(User user, User followed, DateTime createdOn, CancellationToken cancellationToken)
    {
        if (user.Id == followed.Id)
            return FollowerServiceErrors.SameUser;

        if (!followed.IsPublic)
            return FollowerServiceErrors.ProfileIsNotPublic;

        if (await _followeRepository.IsAlreadyFollowingAsync(user.Id, followed.Id, cancellationToken))
            return FollowerServiceErrors.AlreadyFollowing;

        var follower = Follower.Create(user.Id, followed.Id, createdOn);
        _followeRepository.InsertAsync(follower);

        return Result.Success();
    }
}
