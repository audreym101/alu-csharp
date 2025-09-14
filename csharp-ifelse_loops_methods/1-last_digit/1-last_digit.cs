using System;

class Program
{
    static void Main(string[] args)
    {
        int[] testNumbers = { 98, -98, 0 };

        foreach (int number in testNumbers)
        {
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
}
