﻿using System;
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
                int division = list1[i] / list2[i];
                result.Add(division);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                // Do not add anything to result
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                // Do not add anything to result
            }
        }

        return result;
    }
}
