namespace Practice2.Task4b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            for (int i = 0; i < 5; i++)
            {
                int z = 5 - n;
                for (int f = 0; f < z; f++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                n++;
                Console.WriteLine();
            }

        }
    }
}
