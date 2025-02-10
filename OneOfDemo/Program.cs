using OneOf;

// https://github.com/mcintyre321/OneOf

OneOf<Success, Error> result = OneOf<Success, Error>.FromT0(new Success("Hello World"));
string message = result.Match(
    success => $"Success: {success.Message}",
    error => $"Error: {error.Message}"
);
Console.WriteLine(message);

public record Success(string Message);
public record Error(string Message);


//// Future C# (hypothetical)
//union Result { Success; Error; }
//Result result = new Success("Done");
//var output = result switch { Success s => s.Message, Error e => e.Details };