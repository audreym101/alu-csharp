using System;

class Program
{
    static void Main(string[] args)
    {
        // Read number from input
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine($"{number} is positive");
        }
        else if (number < 0)
        {
            Console.WriteLine($"{number} is negative");
        }
        else
        {
            Console.WriteLine("0 is zero");
        }
    }
}
