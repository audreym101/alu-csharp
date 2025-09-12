using System;

class Program
{
    static void Main(string[] args)
    {
        // For testing purposes, you can assign these values:
        // int number = 98;   // positive test
        // int number = -98;  // negative test
        // int number = 0;    // zero test

        int number = int.Parse(Console.ReadLine()); // optional: read input for testing

        if (number > 0)
            Console.WriteLine($"{number} is positive");
        else if (number < 0)
            Console.WriteLine($"{number} is negative");
        else
            Console.WriteLine($"{number} is zero");
    }
}
