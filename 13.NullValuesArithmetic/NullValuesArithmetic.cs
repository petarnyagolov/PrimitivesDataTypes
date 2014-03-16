using System;

    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? intNull = null;
            double? doubleNull = null;
            Console.WriteLine(intNull);
            Console.WriteLine(doubleNull);
            intNull += 2;
            doubleNull += 1.2;
            Console.WriteLine("Integer plus number="+ intNull);
            Console.WriteLine("Double plus number="+ doubleNull);
            intNull = 2;
            doubleNull = 1.2;
            Console.WriteLine(intNull);
            Console.WriteLine(doubleNull);
        }
    }

