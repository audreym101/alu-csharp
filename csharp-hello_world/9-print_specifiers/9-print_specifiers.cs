using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = 0.7553;      // 75.53%
        double currency = 98765.4321;  // $98,765.43
        Console.WriteLine($"Percent: {percent:P2} tip"); 
        Console.WriteLine($"Currency: {currency:C2}");
    }
}