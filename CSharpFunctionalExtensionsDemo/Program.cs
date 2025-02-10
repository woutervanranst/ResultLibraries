using CSharpFunctionalExtensions;

Result<string> result = Result.Success("Hello World");
Console.WriteLine(result.IsSuccess
    ? $"Success: {result.Value}"
    : $"Error: {result.Error}");

//// Future C# (hypothetical)
//union Result { Success; Error; }
//Result result = new Success("Done");
//var output = result switch { Success s => s.Message, Error e => e.Details };