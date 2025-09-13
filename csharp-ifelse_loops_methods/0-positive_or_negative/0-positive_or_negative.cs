using System;

class Program
{
    static void Main(string[] args)
    {
        int number;

        // Test 1: positive
        // number = 98;

        // Test 2: negative
        // number = -98;

        // Test 3: zero
        number = 0;

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
// This program checks if a number is positive, negative, or zero and prints the result.