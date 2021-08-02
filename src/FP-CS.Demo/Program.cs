﻿using FP_CS;

var validateCredentials = Function.Flow(
    Either.FromPredicate<Error, Credentials>(
        credentials => credentials.Username == "root",
        Function.Constant(new Error("Invalid username"))
    ),
    Either.Chain(Either.FromPredicate<Error, Credentials>(
        credentials => credentials.Password == "p4ssw0rd",
        Function.Constant(new Error("Invalid password"))
    ))
);

Function.Pipe(
    new Credentials("root", "p4ssw0rd"),
    validateCredentials,
    Either.Map<Error, Credentials, string>(s => "hehe"),
    Either.Match<Error, string, Unit>(
        error => Console.WriteLine(error.Message),
        credentials => Console.WriteLine("Successful login")
    )
);

record Credentials(string Username, string Password);
record Error(string Message);

