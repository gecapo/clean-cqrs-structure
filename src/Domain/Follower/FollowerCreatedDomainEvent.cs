namespace Domain;

public sealed record FollowerCreatedDomainEvent(Guid UserId, Guid FollowedId, DateTime CreatedOn) : IDomainEvent;
