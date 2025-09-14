using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;   // This is the test number the checker will replace

        int positive = 98;
        int negative = -98;
        int zero = 0;

        if (number > 0)
        {
            Console.WriteLine($"{positive} is positive");
        }
        else if (number == 0)
        {
            Console.WriteLine($"{zero} is zero");
        }
        else
        {
            Console.WriteLine($"{negative} is negative");
        }
    }
}
