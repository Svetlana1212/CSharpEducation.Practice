using System.Xml.Linq;

namespace Practice2.Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            createAnArray(num);

            static void createAnArray(int n)            
            {
                string [] array = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Введите строку:");
                    string str=Console.ReadLine();
                    array[i] = str;
                    //Console.WriteLine(array[i]);
                }
                Console.WriteLine();
                foreach (string element in array)
                {
                    
                    Console.WriteLine(element);
                }
            }
        }
    }
}
