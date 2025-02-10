using FluentResults;

Result<string> result = Result.Ok("Hello World");
Console.WriteLine(result.IsSuccess
    ? $"Success: {result.Value}"
    : $"Error: {string.Join(", ", result.Errors)}");

//// Future C# (hypothetical)
//union Result { Success; Error; }
//Result result = new Success("Done");
//var output = result switch { Success s => s.Message, Error e => e.Details };