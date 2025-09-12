using System;

class Program
{
    static void Main()
    {
        // Test positive, negative, or zero
        // Uncomment the one you want to test:

        int number = 98;   // positive
        // int number = -98;  // negative
        // int number = 0;    // zero

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
            Console.WriteLine($"{number} is zero");
        }
    }
}
