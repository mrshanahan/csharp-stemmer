# csharp-stemmer

A reference implementation of the Porter stemmer written in C# by someone else. See: https://tartarus.org/martin/PorterStemmer/csharp2.txt _(originally accessed: 03/29/2024)_

I am not including the original author's name in this README lest someone see my code & unfairly attempt to contact the author to make some gripe that is actually my fault, but their name & email address is available on the main site. (Leif - if you'd like to either be explicitly listed here or if you'd like this taken down for whatever reason, please let me know.)

I have been using this to test my own version of the Porter stemmer in Go. The code I have borrowed is located in the [PorterStemmer.cs](./PorterStemmer.cs) file. The only modifications made to that code were:

1. removing the outer `namespace` declaration,
2. removing the `ClassInterface` attribute, and
3. removing unused imports (all of them, after the last item).

These were needed for convenience & to get the code to compile in the brave new world of .NET 8.

All other files were written by me/robots, including the harness code in [Program.cs](./Program.cs) as well as any project/solution files.

## Building & Running

This project uses `dotnet` to compile & run:

    $ dotnet build
    $ dotnet run

Inputs are taken from the command line, or from stdin if the sole argument is `-`:

    $ # Command-line args
    $ dotnet run agreed filing
    agre
    file

    $ # From manual stdin
    $ dotnet run -
    agreed
    agre
    filing
    file

    $ # From piped stdin
    $ cat inputs.txt
    agreed
    filing
    $ cat inputs.txt | dotnet run -
    agre
    filing

## Contact

mrshanahan11235@gmail.com