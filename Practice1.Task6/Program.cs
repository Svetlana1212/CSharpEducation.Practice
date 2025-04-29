internal class Program
{
    private static void Main(string[] args)
    {
        int triangleCatheter1 = 33;
        int triangleCatheter2 = 15;
        var Hypotenuse = Math.Sqrt(Math.Pow(triangleCatheter1, 2) + Math.Pow(triangleCatheter2, 2));
        var hypotenuse= Math.Round(Hypotenuse,2);
        Console.WriteLine($"Если первый катет равен {triangleCatheter1}, а второй {triangleCatheter2}, то гипотенуза равна - {hypotenuse} ");
        int triangleCatheter3 = 30;
        int hypotenuse1 = 50;
        var TriangleCatheter4 = Math.Sqrt(Math.Pow(hypotenuse1, 2) - Math.Pow(triangleCatheter3, 2));
        var triangleCatheter4 = Math.Round(TriangleCatheter4, 2);
        Console.WriteLine($"Если первый катет равен {triangleCatheter3}, а гипотенуза равна  {hypotenuse1}, то второй катет равен - {triangleCatheter4}");

    }
}