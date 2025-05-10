namespace Practice2.Task7a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку в нижнем регистре и нажмите Enter: ");
            string string1 = Console.ReadLine();
            string String2 = string1.ToUpper();
            Console.WriteLine(String2);

        }
    }
}
