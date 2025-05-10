namespace Practice2.Task7b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку в верхнем регистре и нажмите Enter: ");
            string string1 = Console.ReadLine();
            string String2 = string1.ToLower();
            Console.WriteLine(String2); ;
        }
    }
}
