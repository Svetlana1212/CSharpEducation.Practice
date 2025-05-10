namespace Practice2.Task17
{
    internal class Program
    {
        static void ReverseNumbers(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
            
        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            ReverseNumbers(ref x,ref y);
            Console.WriteLine($"x={x},y={y}");
        }
    }
}
