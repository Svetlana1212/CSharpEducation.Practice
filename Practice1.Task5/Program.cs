internal class Program
{
    private static void Main(string[] args)
    {
        const double pi = 3.14;
        double radius = 15;
        double square = Math.Pow(radius, 2) * pi;
        Console.WriteLine($"Площадь круга с радиусом {radius} м равна {square}");
    }
}