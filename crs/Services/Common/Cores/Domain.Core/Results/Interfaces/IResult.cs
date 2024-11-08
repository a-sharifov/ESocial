using Domain.Core.Errors;

namespace Domain.Core.Results.Interfaces;

public interface IResult
{
    Error Error { get; }
    bool IsFailure { get; }
    bool IsSuccess { get; }
}