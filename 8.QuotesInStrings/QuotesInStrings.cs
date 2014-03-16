using System;

class QuotesInStrings
{
    static void Main()
    {
        string with = "The \"use\" of quotations causes difficulties.";
        string without = "The" + '"' + "use" + '"' + " of quotations causes difficulties.";
        Console.WriteLine(without);
        Console.WriteLine(with);
    }
}

