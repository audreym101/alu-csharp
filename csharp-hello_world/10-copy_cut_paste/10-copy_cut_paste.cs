using System;

class Program
{
    static void Main(string[] args)
    {
        string word = "Holberton";

        // First 3 letters
        string word_first_3 = word.Substring(0, 3);

        // Last 2 letters
        string word_last_2 = word.Substring(word.Length - 2, 2);

        // Middle word without first and last letters
        string middle_word = word.Substring(1, word.Length - 2);

        Console.WriteLine("First 3 letters: " + word_first_3);
        Console.WriteLine("Last 2 letters: " + word_last_2);
        Console.WriteLine("Middle word: " + middle_word);
    }
}
