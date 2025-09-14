using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(-10000, 10000); // Do not touch this line

        int lastDigit = number % 10;

        Console.Write("The last digit of ");
        Console.Write(number);
        Console.Write(" is ");
        Console.Write(lastDigit);

        if (lastDigit > 5)
        {
            Console.WriteLine(" and is greater than 5");
        }
        else if (lastDigit == 0)
        {
            Console.WriteLine(" and is 0");
        }
        else
        {
            Console.WriteLine(" and is less than 6 and not 0");
        }
    }
}
// The variable 'number' will have a different value every time you will run this program
// The variable 'lastDigit' should be the last digit of 'number'