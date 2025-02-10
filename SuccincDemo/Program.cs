using SuccincT.Unions;

// https://github.com/DavidArno/SuccincT/wiki/PatternMatchingUnions#caseoftype-usage

var result = new Union<Success, Error>(new Success("Hello World"));
var message = result.Match<string>()
    .CaseOf<Success>().Do(s => $"Success: {s.Message}")
    .CaseOf<Error>().Do(s => $"Success: {s.Message}")
    .Result();
Console.WriteLine(message);

public record Success(string Message);
public record Error(string Message);