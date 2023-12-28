namespace Domain;

public static class FollowerServiceErrors
{
    public static readonly Error SameUser = new($"{nameof(FollowerService)}{nameof(SameUser)}", "Can't follow yourself!");
    public static readonly Error AlreadyFollowing = new($"{nameof(FollowerService)}{nameof(AlreadyFollowing)}", "Already following!");
    public static readonly Error ProfileIsNotPublic= new($"{nameof(FollowerService)}{nameof(ProfileIsNotPublic)}", "User is private!");

}