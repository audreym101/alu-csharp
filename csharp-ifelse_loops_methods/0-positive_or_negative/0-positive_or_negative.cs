using System;

class Program
{
    static void Main(string[] args)
    {
        int number;

        // Uncomment the one you need for each test case:

        number = 98; -98; 0;   // positive test
        // number = -98;  // negative test
        // number = 0;    // zero test

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
