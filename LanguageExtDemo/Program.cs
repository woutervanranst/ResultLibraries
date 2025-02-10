using LanguageExt;

Either<Success, Error> result = new Success("Hello World");
var message = result.Match(
    Left: msg => $"Success: {msg}",
    Right: err => $"Error: {err}"
);
Console.WriteLine(message);

public record Success(string Message);
public record Error(string Message);