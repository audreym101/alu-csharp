using System;

class Program
{
    static void Main(string[] args)
    {
        int number;

        // Uncomment one line depending on the test case:

        number = 98;    // positive test
        // number = -98;   // negative test
        // number = 0;     // zero test

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
        