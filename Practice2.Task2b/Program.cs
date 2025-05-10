namespace Practice2.Task2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество километров: ");
            double km = double.Parse(Console.ReadLine());
            double sm = km*100000;
            Console.WriteLine($" в {km} километрах {sm} сантиметров");
        }
    }
}
