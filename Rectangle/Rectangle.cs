using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        private double length;
        private double width;

        private static int count;

        public Rectangle()
        {

        }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetLength()
        {
            return length;
        }

        public void SetLength(double length)
        {
            this.length = length;
        }

        public double GetWidth()
        {
            return width;
        }

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public double GetArea()
        {
            return length * width;
        }

        public static int GetCount()
        {
            return count;
        }

        public static void SetCount(int count)
        {
            Rectangle.count = count;
        }

        public static void IncCount()
        {
            count++;
        }

    }
}
