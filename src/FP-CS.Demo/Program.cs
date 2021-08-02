using System;
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

var result = validateCredentials(new Credentials("root", "p4ssw0rd"));

record Credentials(string Username, string Password);
record Error(string Message);

