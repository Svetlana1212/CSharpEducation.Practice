namespace Practice2.Task9
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int num = 4;
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
