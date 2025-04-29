internal class Program
{
    private static void Main(string[] args)
    {
        int age = 45;
        string name = "Светлана";
        double temperature = 35.5;
        bool femaleGender = true;
        string gender = (femaleGender) ? "женский" : "мужской";
        Console.WriteLine($"Имя: {name} Возраст: {age} Температура воздуха: {temperature} Пол: {gender}"); 
    }
}