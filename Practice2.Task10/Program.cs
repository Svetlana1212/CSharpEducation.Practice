using System;

namespace Practice2.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(args[0]);
            createAnArray(num);
            static void createAnArray(int n)
            {
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = i;
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
