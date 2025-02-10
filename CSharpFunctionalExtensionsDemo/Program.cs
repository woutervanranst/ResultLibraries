using CSharpFunctionalExtensions;

Result<string> result = Result.Success("Hello World");
Result<string> failureResult = Result.Failure<string>("Something went wrong");

string message = result.IsSuccess
    ? $"Success: {result.Value}"
    : $"Error: {result.Error}";

Console.WriteLine(message);
