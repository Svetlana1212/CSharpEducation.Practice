using System.Drawing;

namespace Practice3.Task8
{
    internal class Program
    {
        class Rectangle
        {
            public int width;
            public int height;
            public Rectangle(int newWidth, int newHeight)
            {
                width = newWidth;
                height = newHeight;
            }
        }
        static double Square(Rectangle myRectangle)
        {
            return myRectangle.width*myRectangle.height;
        }
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle(10,4);
            Console.WriteLine(Square(myRectangle));
        }
    }
}
