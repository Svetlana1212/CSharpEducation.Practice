namespace Practice2.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную a:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b:");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную c:");
            int c = Int32.Parse(Console.ReadLine());
            if ((a == b) || (b == c) || (a == c)) {
                a = a + 5;
                b = b + 5;
                c = c + 5;
                Console.WriteLine($"a={a},b={b},c={c}");
            } else
            {
                Console.WriteLine("Равных нет");
            }

        }
    }
}
