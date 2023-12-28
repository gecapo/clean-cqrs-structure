namespace Domain;

public class Result
{
    private Result(bool isSuccessful, Error error)
    {
        IsSuccessful = isSuccessful;
        Error = error;
    }

    public bool IsSuccessful { get; }

    public Error Error { get; }

    public static Result Success() => new(true, Error.None);
    public static Result Failure(Error error) => new(false, error);
}