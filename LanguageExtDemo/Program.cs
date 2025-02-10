using LanguageExt;
using static LanguageExt.Prelude;

Either<string, string> result = Right("Hello World");
result.Match(
    Right: msg => Console.WriteLine($"Success: {msg}"),
    Left: err => Console.WriteLine($"Error: {err}")
);