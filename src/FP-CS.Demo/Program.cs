using FP_CS;

var validateCredentials = Function.Flow(
    Either.FromPredicate<Error, Credentials>(
        credentials => credentials.Username == "root",
        () => new Error("Invalid username")
    ),
    Either.Chain(Either.FromPredicate<Error, Credentials>(
        credentials => credentials.Password == "p4ssw0rd",
        () => new Error("Invalid password")
    ))
);

Function.Pipe(
    new Credentials("root", "p4ssw0rd"),
    validateCredentials,
    Either.Match<Error, Credentials, Unit>(
        error => Console.WriteLine(error.Message),
        credentials => Console.WriteLine("Successful login")
    )
);

record Credentials(string Username, string Password);
record Error(string Message);

