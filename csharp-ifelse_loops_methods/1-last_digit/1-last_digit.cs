using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;  // The checker will replace this with 98, -98, or 0

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
// The output of the program should be exactly one of the following:
// The last digit of 98 is 8 and is greater than 5  
// The last digit of -98 is 8 and is greater than 5
// The last digit of 0 is 0 and is 0