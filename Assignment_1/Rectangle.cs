using System;
namespace Assignment_1
{
    public class Rectangle
    {
        private int Length;
        private int Width;

        public Rectangle()
        {
            this.Length = 1;
            this.Width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }

        public int GetLength()
        {
            return Length;
        }

        public void SetLength(int length)
        {
            this.Length = length;
        }

        public int GetWidth()
        {
            return Width;
        }

        public void SetWidth(int width)
        {
            this.Width = width;
        }

        public int GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public int GetArea()
        {
            return Length * Width;
        }
    }
}
