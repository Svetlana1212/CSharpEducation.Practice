namespace Practice2.Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 10];

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int max = 0;
                int min = 100;
                for (int j = 0; j < 10; j++)
                {
                    a[i, j] = random.Next(100);
                    if (a[i, j]>max)
                    {
                        max = a[i, j];
                    }
                    if(a[i, j] > min)
                    {
                        min = a[i, j];
                    }
                    Console.Write("{0,4}", a[i, j]);
                }
                int ras = max - min;
                Console.WriteLine($" Максимум строки {max}, минимум {min} разность равна:{ras}");
            }
        }
    }
}
