using System;

class Program
{
    static void Main(string[] args)
    {
        // DO NOT TOUCH THIS
        Random rand = new Random();
        int number = rand.Next(-10, 11); // assigns a random number between -10 and 10

        // Print whether the number is positive, negative, or zero
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
