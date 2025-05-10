namespace Practice2.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            do
            {
                Console.WriteLine("Введите переменную a не равную 0 и нажмите Enter");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Некорректный ввод");                    
                }
                
            } while (a == 0);
            
            
            Console.WriteLine("Введите переменную b и нажмите Enter");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную f и нажмите Enter");
            int f = Convert.ToInt32(Console.ReadLine());
            var result = (a + b - f / a) + f * a * a - (a + b);
            Console.WriteLine($" результат вычисления: {result}");

        }
    }
}
