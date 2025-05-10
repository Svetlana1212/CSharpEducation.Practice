namespace Practice2.Task2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру в градусах C, нажмите Enter: ");
            double grad = double.Parse(Console.ReadLine());
            var fo = (grad * 9/5 + 32);
            Console.WriteLine($" {grad} градусов С равно {fo} градусов F");
        }
    }
}
