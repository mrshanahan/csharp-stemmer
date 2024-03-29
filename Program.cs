var stemmer = new PorterStemmer();
if (args.Length == 1 && args[0] == "-")
{
    using (StreamReader reader = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding))
    {
        string? line;
        while (!reader.EndOfStream)
        {
            line = reader.ReadLine();
            if (!string.IsNullOrEmpty(line))
            {
                Console.WriteLine(stemmer.stemTerm(line));
            }
        }
    }
}
else
{
    foreach (var arg in args)
    {
        Console.WriteLine(stemmer.stemTerm(arg));
    }
}

