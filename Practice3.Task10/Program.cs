namespace Practice3.Task10
{
    internal class Program
    {
        class Automobile
        {
            public string Brand;
            public Automobile(string brand) 
            { 
                Brand = brand;
            }
        }
        static void Info(Automobile automobile)
        {
            Console.WriteLine(automobile.Brand);
        }
        static void Main(string[] args)
        {
            Automobile Lada = new Automobile("Лада Приора");
            Info(Lada);
        }
    }
}
