using System;

class Program
{
    static void Main(string[] args)
    {
        int[] testNumbers = {98, -98, 0};

        foreach (int number in testNumbers)
        {
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
}
