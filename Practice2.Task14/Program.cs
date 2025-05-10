namespace Practice2.Task14
{
    internal class Program
    {
        static int[] createAnArray(int n)
        {
            int[] arr = new int[n];
            return arr;
        }
        
        static void Main(string[] args)
        {
            int[] newArray = createAnArray(5);//.OfType<int>().ToArray();
            for (int i = 0; i < 5; i++)
            {
                newArray[i] = i*i;
                Console.WriteLine(newArray[i]);
            }
            
        }
    }
}
