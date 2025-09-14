using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;  // The checker will replace this with 98, -98, or 0

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
