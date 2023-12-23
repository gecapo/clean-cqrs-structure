namespace Domain.Users;

public sealed record Name
{
    public string Value { get; }

    public Name(string? value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        Value = value;
    }
}
