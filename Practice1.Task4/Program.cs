internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя, а затем нажмите Enter");
        string name = Console.ReadLine();
        Console.WriteLine("Введите ваше отчество, а затем нажмите Enter");
        string patronymic = Console.ReadLine();
        Console.WriteLine($"Привет, {name} {patronymic}!");
    }
}