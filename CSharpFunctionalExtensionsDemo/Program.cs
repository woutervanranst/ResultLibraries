using CSharpFunctionalExtensions;

Result<string> result = Result.Success("Hello World");
Console.WriteLine(result.IsSuccess
    ? $"Success: {result.Value}"
    : $"Error: {result.Error}");