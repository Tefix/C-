using System.Globalization;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("write ur name");
            string nimi = Console.ReadLine();
            Console.WriteLine("hello " + nimi);

            if (string.IsNullOrEmpty(nimi) || !nimi.All(char.IsLetter))
            {
                Console.WriteLine("error");
                Console.Beep();
            }
        }
    }
}
