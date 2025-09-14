using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("98 is positive");
        }
        else if (number == 0)
        {
            Console.WriteLine("0 is zero");
        }
        else
        {
            Console.WriteLine("-98 is negative");
        }
    }
}
