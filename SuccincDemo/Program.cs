using SuccincT.Unions;

// https://github.com/DavidArno/SuccincT/wiki/PatternMatchingUnions#caseoftype-usage

Union<Success, Error> result = new Union<Success, Error>(new Success("Hello World"));
string message = result.Match<string>()
    .CaseOf<Success>().Do(s => $"Success: {s.Message}")
    .CaseOf<Error>().Do(s => $"Success: {s.Message}")
    .Result();
Console.WriteLine(message);

public record Success(string Message);
public record Error(string Message);

//// Future C# (hypothetical)
//union Result { Success; Error; }
//Result result = new Success("Done");
//var output = result switch { Success s => s.Message, Error e => e.Details };