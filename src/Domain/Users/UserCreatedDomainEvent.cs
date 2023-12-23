namespace Domain.Users;

public sealed record UserCreatedDomainEvent(Guid UserId, DateTime CreatedOn) : IDomainEvent;
