using OneOf;

// https://github.com/mcintyre321/OneOf

var result = OneOf<Success, Error>.FromT0(new Success("Hello World"));
var message = result.Match(
    success => $"Success: {success.Message}",
    error => $"Error: {error.Message}"
);
Console.WriteLine(message);

public record Success(string Message);
public record Error(string Message);