using LanguageExt;

Either<Success, Error> result = new Success("Hello World");
Either<Success, Error> failureResult = new Error("Something went wrong");

string message = result.Match(
    Left: msg => $"Success: {msg}",
    Right: err => $"Error: {err}"
);
Console.WriteLine(message);

public record Success(string Message);
public record Error(string Message);