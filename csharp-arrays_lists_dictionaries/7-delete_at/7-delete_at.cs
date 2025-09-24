using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        // Shift elements left
        for (int i = index; i < myList.Count - 1; i++)
        {
            myList[i] = myList[i + 1];
        }

        // Remove the last element (duplicate)
        myList.RemoveAt(myList.Count - 1); // If not allowed, see alternative below

        return myList;
    }
}
        // Alternative if RemoveAt is not allowed:
        // myList.RemoveAt(myList.Count - 1); // Remove the last element (duplicate)
        // return myList.GetRange(0, myList.Count - 1); // Return a new list without the last element