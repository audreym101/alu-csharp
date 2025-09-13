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
        // DO NOT TOUCH THIS --- IGNORE ---
        Random rand = new Random(); // --- IGNORE ---
        int number = rand.Next(-10, 11); // assigns a random number between -10 and 10 --- IGNORE ---
        // --- IGNORE ---
        // YOUR CODE BELOW --- IGNORE ---