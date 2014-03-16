using System;

class ComparingFloats
{
    static void Main()
    {
        decimal presicion = 0.000001m;
        float firsta = 5.3f;
        float firstb = 6.01f;
        decimal firstDiff = (decimal)firstb - (decimal)firsta;
        if (firstDiff > presicion)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }

        double seconda = 5.00000001f;
        double secondb = 5.00000003f;
        decimal secondDiff = (decimal)seconda - (decimal)secondb;
        if (secondDiff> presicion)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }
        //izvajdam gi i ako razlikata e po-malka ot presicion kazvam 4e sa ravni!rabotq sus decimal i posle minavam vuv double
        
        decimal thirda = -0.0000007m;
        decimal thirdb = 0.00000007m;
        decimal thirdDiff = thirda + thirdb;
        if (thirdDiff > (decimal)presicion)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }

        double fourtha = -4.999999f;
        double fourthb = -4.999998f;
        decimal fourthDiff = Math.Abs((decimal)fourtha) - Math.Abs((decimal)fourthb);
        if ((fourthDiff > (decimal)presicion) || (fourthDiff<(decimal)presicion))
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }

        
    }
}

