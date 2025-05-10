namespace Practice2.Task1e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordString = "";
            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("Введите слово:");
                string word = Console.ReadLine();
                wordString = wordString + " " + word;
                i++;
            }
            Console.WriteLine(wordString);


        }
    }
}
