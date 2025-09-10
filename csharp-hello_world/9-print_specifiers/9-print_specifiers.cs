using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double percent = 0.7553;
        double amount = 98765.43;

        Console.WriteLine("Percent: {0:P2} tip", percent);
        Console.WriteLine("Currency: {0:C2}", amount);
    }
}
