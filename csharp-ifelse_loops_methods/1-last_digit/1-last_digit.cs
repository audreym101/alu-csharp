using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(-10000, 10000);
        int lastDigit = number % 10; // Keep the sign for negative numbers

        Console.Write($"The last digit of {number} is {lastDigit} and is ");

        if (lastDigit > 5)
            Console.WriteLine("greater than 5");
        else if (lastDigit == 0)
            Console.WriteLine("0");
        else
            Console.WriteLine("less than 6 and not 0");
    }
}
// This program generates a random integer between -10000 and 10000
// and prints the last digit with a description.
