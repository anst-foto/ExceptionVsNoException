namespace ExceptionVsNoException;

public enum ResultType { Success, Failure }

public record Result
{
    public required ResultType Type { get; init; }
    public required double? Value { get; init; }
}