namespace _8_print_variables
{
    class Program
    {
        static int[] number = [972, 98];
        static string[] street = ["Mission", "Battery " + street];
        static void Main(string[] args)
        {
            Console.WriteLine($"{number} {street}");
        }
    }
}