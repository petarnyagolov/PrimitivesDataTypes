using System;

class ExchangeVariablesValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int temp = b;
        Console.WriteLine("a={0},b={1}",a,b);
        b = a;
        a = temp;
        Console.WriteLine("a={0},b={1}", a, b);
    }
}   

