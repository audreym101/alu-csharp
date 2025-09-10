using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = 0.7553; // change to negative or 0 as needed
        double currency = 98765.4321; // change to negative or 0 as needed
        Console.WriteLine("Percent: {0:P2} tip", percent);
        Console.WriteLine("Currency: {0:C2}", currency);
    }
}