namespace Practice2.Task2c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость в метрах в секунду, нажмите Enter: ");
            double metrSec = double.Parse(Console.ReadLine());
            double kmh = (metrSec*1000)/3600;
            Console.WriteLine($" {metrSec} метров в секунду равно {kmh} километров в час");
        }
    }
}
