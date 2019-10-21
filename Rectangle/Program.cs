using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of rectangles: " + Rectangle.GetCount());

            Rectangle myRectangle1 = new Rectangle();
            Rectangle.IncCount();
            double area1 = myRectangle1.GetArea();
            Console.WriteLine("Rectangle1 length: " + myRectangle1.GetLength() + ", Rectangle1 width: " + myRectangle1.GetWidth());
            Console.WriteLine("Area for Rectangle1: " + area1);
            Console.WriteLine("Number of rectangles: " + Rectangle.GetCount());

            Rectangle myRectangle2 = new Rectangle(10, 5.5);
            Rectangle.IncCount();
            double area2 = myRectangle2.GetArea();
            Console.WriteLine("Rectangle2 length: " + myRectangle2.GetLength() + ", Rectangle2 width: " + myRectangle2.GetWidth());
            Console.WriteLine("Area for Rectangle2: " + area2);
            Console.WriteLine("Number of rectangles: " + Rectangle.GetCount());
            
            Console.ReadKey();
        }
    }
}
