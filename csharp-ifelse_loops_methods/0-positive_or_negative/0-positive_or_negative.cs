using System;

class Program
{
    static void Main()
    {
        // Change this value to test each case
        int number = 98;   // positive test
        // int number = -98; // negative test
        // int number = 0;   // zero test

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
