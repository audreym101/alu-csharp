using System;
class Program
{
    static void Main(string[] args)
    {
        double percent = 0.2641;      
        double currency = 12345.678;  
        Console.WriteLine($"Percent: {percent:P2} tip");
        Console.WriteLine($"Currency: {currency:C2}");
    }
}
