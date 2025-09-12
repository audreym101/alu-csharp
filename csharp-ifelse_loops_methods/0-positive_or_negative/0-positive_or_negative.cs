using System;

class Program
{
    static void Main(string[] args)
    {
        // DO NOT TOUCH THIS
        Random rand = new Random();
        int number = rand.Next(-10, 11); // assigns a random number between -10 and 10

        // YOUR CODE BELOW
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
