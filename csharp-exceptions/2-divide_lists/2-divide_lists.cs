using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                result.Add(list1[i] / list2[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0);  // Add 0 for this failed division
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                result.Add(0);  // Add 0 if index is out of range
            }
        }

        return result;
    }
}
