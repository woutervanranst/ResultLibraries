using FluentResults;

var result = Result.Ok("Hello World");
Console.WriteLine(result.IsSuccess
    ? $"Success: {result.Value}"
    : $"Error: {string.Join(", ", result.Errors)}");