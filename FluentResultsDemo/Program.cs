using FluentResults;

Result<string> result = Result.Ok("Hello World");
Result failureResult = Result.Fail("Something went wrong");

var message = result.IsSuccess
    ? $"Success: {result.Value}"
    : $"Error: {string.Join(", ", result.Errors)}";

Console.WriteLine(message);