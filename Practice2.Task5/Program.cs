namespace Practice2.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int number1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1> number2) {
                Console.WriteLine("Первое число больше второго числа"); 
            }else if(number2 > number1) {
                Console.WriteLine("Второе число больше первого числа");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
        }
    }
}
