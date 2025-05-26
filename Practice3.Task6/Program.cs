namespace Practice3.Task6
{
    internal class Program
    {
        class Dot
        {
            public int X;
            public int Y;
            public Dot(int x, int y) 
            { 
                X = x;
                Y = y;
            }
            
        }
        static double Distance(Dot Dot1, Dot Dot2)
        {
            return Math.Sqrt(Math.Pow((Dot1.X-Dot2.X),2)+ Math.Pow((Dot1.Y-Dot2.Y),2));
        }
        static void Main(string[] args)
        {
            Dot Dot1 = new Dot(5,6);
            Dot Dot2 = new Dot(10,6);

            Console.WriteLine(Distance(Dot1, Dot2));
        }
    }
}
