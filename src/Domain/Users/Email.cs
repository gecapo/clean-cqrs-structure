namespace Domain.Users;

public sealed record Email
{
    public string Value { get; }

    public Email(string? value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        Value = value;
    }
}
