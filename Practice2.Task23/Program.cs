namespace Practice2.Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год: ");
            int Year=Convert.ToInt32(Console.ReadLine());
            if (Year % 400 == 0)
            {
                Console.WriteLine("Год високосный");
            }
            else if (Year % 100 == 0)
            {
                Console.WriteLine("Год невисокосный");
            }
            else if (Year % 4 == 0 )
            {
                Console.WriteLine("Год високосный");
            }
            else 
            {
                Console.WriteLine("Год невисокосный");
            }
        }
    }
}
