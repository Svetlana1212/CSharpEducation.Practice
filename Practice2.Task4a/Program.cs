namespace Practice2.Task4a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            for (int i = 0; i < 5; i++)
            {

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
