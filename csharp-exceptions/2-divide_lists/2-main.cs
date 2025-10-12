// main_0.cs
using System;

class Main0
{
    static void Main(string[] args)
    {
        int[] list1 = {10, 0, 4};
        int[] list2 = {2, 4, 0};

        for (int i = 0; i < Math.Max(list1.Length, list2.Length); i++)
        {
            try
            {
                Console.WriteLine(list1[i] / list2[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
    }
}

// main_1.cs → class Main1 { ... }
// main_2.cs → class Main2 { ... }
