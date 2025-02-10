using FluentResults;

Result<string> result = Result.Ok("Hello World"); // Has a built-in Result type
Result<string> failureResult = Result.Fail("Something went wrong");

var message = result.IsSuccess
    ? $"Success: {result.Value}"
    : $"Error: {string.Join(", ", result.Errors)}";

Console.WriteLine(message);