namespace Domain;

public abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = new();
    protected Entity(Guid id)
    {
        Id = id;
    }

    protected Entity() { }

    protected void RaiseEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);
    public List<IDomainEvent> DomainEvents => _domainEvents.ToList();

    public Guid Id { get; init; }
}
