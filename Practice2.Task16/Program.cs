using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice2.Task16
{
    internal class Program
    {
        static void ModifyValue(ref int value)
        {
            value *= -1;
        }
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("Оригинальное число: " + num);

            ModifyValue(ref num);

            Console.WriteLine("Преобразованное число: " + num);
            
        }
    }
}
