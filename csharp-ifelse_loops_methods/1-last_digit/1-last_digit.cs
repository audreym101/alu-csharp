using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(-10000, 10000); // Do not touch this line

        int lastDigit = number % 10;
        string message;

        if (lastDigit > 5)
        {
            message = "and is greater than 5";
        }
        else if (lastDigit == 0)
        {
            message = "and is 0";
        }
        else
        {
            message = "and is less than 6 and not 0";
        }

        Console.WriteLine($"The last digit of {number} is {lastDigit} {message}");
    }
}
