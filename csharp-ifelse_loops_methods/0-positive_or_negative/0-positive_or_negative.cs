using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 98;  // default value

        if (args.Length > 0)
        {
            number = Convert.ToInt32(args[0]);
        }

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
            Console.WriteLine("0 is zero");
        }
    }
}
