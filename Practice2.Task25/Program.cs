namespace Practice2.Task25
{
    internal class Program
    {
        enum Weekday
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            bool Valid;
            do
            {
                Console.WriteLine("Введите номер дня недели(от 1 до 7):");
                Valid = Int32.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= 7;
                if (Valid)
                {
                    Console.WriteLine(Enum.GetName(typeof(Weekday), num));
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            } while (Valid != true);
        }
    }
}
