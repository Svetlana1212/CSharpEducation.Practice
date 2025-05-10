namespace Practice2.Task4c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ для прорисовки треугольника: ");
            string simvol= Console.ReadLine();
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
                    Console.Write(simvol);
                }
                n++;
                Console.WriteLine();
            }

        }
    }
}
