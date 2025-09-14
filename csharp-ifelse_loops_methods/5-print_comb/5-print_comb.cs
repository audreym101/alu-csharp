using System;

class Program
{
    static void Main(string[] args)
    {
        string numbers = "";
        for (int i = 0; i <= 99; i++)
        {
            numbers += i.ToString("D2"); // Format as 2 digits
            if (i != 99)                 // Add separator for all but the last
                numbers += ", ";
        }
        Console.WriteLine(numbers);      // Only one write needed, prints newline at end
    }
}
