namespace Domain.Users;

public sealed record UserCreatedDomainEvent(Guid userId) : IDomainEvent;
