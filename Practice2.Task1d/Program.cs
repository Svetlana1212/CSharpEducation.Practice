using System.Diagnostics.Tracing;

namespace Practice2.Task1d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordString = "";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите слово:");
                string word = Console.ReadLine();
                wordString = wordString + " " + word;

            }
            Console.WriteLine(wordString);
        }
    }
}
