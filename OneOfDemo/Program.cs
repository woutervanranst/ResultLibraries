using OneOf;

var result = OneOf<Success, Error>.FromT0(new Success("Hello World"));
result.Switch(
    success => Console.WriteLine($"Success: {success.Message}"),
    error => Console.WriteLine($"Error: {error.Message}")
);

public record Success(string Message);
public record Error(string Message);