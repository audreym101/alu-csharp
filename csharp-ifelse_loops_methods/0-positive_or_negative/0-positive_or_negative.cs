using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(-10, 10); // Do not touch this line

        if (number > 0)
        {
            Console.WriteLine($"{number} is positive");
        }
        else if (number == 0)
        {
            Console.WriteLine($"{number} is zero");
        }
        else
        {
            Console.WriteLine($"{number} is negative");
        }
    }
}
