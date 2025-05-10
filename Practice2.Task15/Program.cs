namespace Practice2.Task15
{
    internal class Program
    {
        static Array arrayReverse(int[] myArray)
        {
            int[] arrReverse=new int[myArray.Length];
            int n = myArray.Length-1;
            for(int i=0; i<myArray.Length; i++)
            {
                int a = myArray[i];
                arrReverse[n-i] = a;
                
            }
            return arrReverse;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int[] newArray = arrayReverse(arr).OfType<int>().ToArray();
            for (int i = 0; i < newArray.Length; i++) 
            {
                Console.WriteLine(newArray[i]);
            }
            
        }
    }
}
