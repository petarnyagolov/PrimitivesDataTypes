using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string h = "Hello";
        string w = "World";
        object helloWorld = h + ' ' + w;
        string hello = helloWorld as string;
        Console.WriteLine(helloWorld);
        Console.WriteLine(hello);

    }
}

