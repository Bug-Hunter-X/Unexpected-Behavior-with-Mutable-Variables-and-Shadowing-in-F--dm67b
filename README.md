# F# Mutable Variable Bug

This repository demonstrates a common error in F# related to the use of mutable variables and the shadowing of variables in nested scopes.

## The Bug

The `bug.fs` file contains code that attempts to swap two mutable integer variables. The swap function itself appears correct, but the output is unexpected. When calling swap with mutable variables, it works as expected; however, trying to swap immutable variables within the scope of the function leads to a compile-time error.

## The Solution

The `bugSolution.fs` file shows how to correctly swap immutable variables using tuples and pattern matching.  This demonstrates correct usage of immutability, a key characteristic of functional programming in F#.

## How to Run

1. Install the .NET SDK.
2. Clone this repository: `git clone https://github.com/<your_username>/fsharp-mutable-bug.git`
3. Navigate to the repository directory.
4. Compile and run using the F# compiler: `dotnet fsi bug.fs` and `dotnet fsi bugSolution.fs`