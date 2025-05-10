namespace Practice2.Task7c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter: ");
            string string1 = Console.ReadLine();
            char simbol = string1[0];
            string Simbol = simbol.ToString().ToUpper();
            string String2 = string1.Substring(1);
            string newString=Simbol+String2;
            Console.WriteLine(newString);
        }
    }
}
