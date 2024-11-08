using Domain.Core.Errors;
using Domain.Core.Results.Interfaces;

namespace Domain.Core.Results;

/// <summary>
/// class for result pattern.
/// </summary>
public class Result : IResult
{
    public Error Error { get; }
    public bool IsSuccess { get; }

    public bool IsFailure => IsSuccess;

    public Result(Error error)
    {
        Error = error;

        if (Error == Error.None)
        {
            IsSuccess = true;
        }
    }

    /// <summary>
    /// Create a success result.
    /// </summary>
    /// <returns> The result.</returns>
    public static Result Success() => new(Error.None);

    /// <summary>
    /// Create a Success return value.
    /// </summary>
    /// <typeparam name="TObject"> The value type.</typeparam>
    /// <param name="value"> The value.</param>
    /// <returns> The result.</returns>
    public static Result<TObject> Success<TObject>(TObject value) => new(value, Error.None);

    /// <summary>
    /// Create a result.
    /// if the value is null, return a failure result.
    /// else return a success result.
    /// </summary>
    /// <typeparam name="TObject"> The value type.</typeparam>
    /// <param name="value"> The value.</param>
    /// <param name="error"> The error.</param>
    /// <returns> The result.</returns>
    public static Result<TObject> Create<TObject>(TObject value, Error error)
        where TObject : class
        => value is null ? Failure<TObject>(error) : Success(value);

    /// <summary>
    /// Create a failure result.
    /// </summary>
    /// <param name="error"> The error.</param>
    /// <returns> The result.</returns>
    public static Result Failure(Error error) => new(error);

    /// <summary>
    /// Create a failure generic result.
    /// </summary>
    /// <typeparam name="TObject"> The value type.</typeparam>
    /// <param name="error"> The error.</param>
    /// <returns> The result.</returns>
    public static Result<TObject> Failure<TObject>(Error error) => new(default!, error);

    /// <summary>
    /// get first failure result or success result.
    /// </summary>
    /// <param name="results"> The results.</param>
    /// <returns> The result.</returns>
    public static Result FirstFailureOrSuccess(params Result[] results)
    {
        foreach (Result result in results)
        {
            if (result.IsFailure)
            {
                return result;
            }
        }

        return Success();
    }
}
