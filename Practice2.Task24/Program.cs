namespace Practice2.Task24
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
            Weekday[] values = (Weekday[])Enum.GetValues(typeof(Weekday));
            foreach (Weekday n in values)
                Console.WriteLine(n);
            //Console.WriteLine(Weekday.Monday);

        }
    }
}
