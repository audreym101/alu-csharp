using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double percent = 0.7553;
        double amount = 98765.43;

        // Percent output
        Console.WriteLine("Percent: {0:P2} tip", percent);
        
        // Currency output
        Console.WriteLine("Currency: {0:C2}", amount);

        // Additional test cases
        percent = -0.7553;
        amount = -98765.43;
        Console.WriteLine("Percent: {0:P2} tip", percent);
        Console.WriteLine("Currency: {0:C2}", amount);

        percent = 0;
        amount = 0;
        Console.WriteLine("Percent: {0:P2} tip", percent);
        Console.WriteLine("Currency: {0:C2}", amount);
    }
}
