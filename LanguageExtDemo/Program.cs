using LanguageExt;

Either<Success, Error> result = new Success("Hello World");
string message = result.Match(
    Left: msg => $"Success: {msg}",
    Right: err => $"Error: {err}"
);
Console.WriteLine(message);

public record Success(string Message);
public record Error(string Message);

//// Future C# (hypothetical)
//union Result { Success; Error; }
//Result result = new Success("Done");
//var output = result switch { Success s => s.Message, Error e => e.Details };