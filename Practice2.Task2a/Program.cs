namespace Practice2.Task2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество метров: ");
            double metr = double.Parse(Console.ReadLine());
            double km = metr / 1000;
            Console.WriteLine($"{metr} метров равно {km} километров");
        }
    }
}
