using OneOf;

// https://github.com/mcintyre321/OneOf

OneOf<Success, Error> result = OneOf<Success, Error>.FromT0(new Success("Hello World"));
OneOf<Success, Error> failureResult = OneOf<Success, Error>.FromT1(new Error("Something went wrong"));

string message = failureResult.Match(
    success => $"Success: {success.Message}",
    error => $"Error: {error.Message}"
);
Console.WriteLine(message);

public record Success(string Message);
public record Error(string Message);