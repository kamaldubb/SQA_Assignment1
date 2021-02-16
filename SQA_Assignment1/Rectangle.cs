using System;
namespace SQA_Assignment1
{
    public class Rectangle
    {
        private int length;
        private int width;
       
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        public Rectangle(int l, int w)
        {
            length = l;
            width = w;
            
        }
        public int GetLength()
        {
            
            return length;
        }
        public int SetLength(int len)
        {

            length = len;
            return length;
        }

        public int GetWidth()
        {

            return width;
        }
        public int SetWidth(int wid)
        {
            width = wid;
            return width;
        }
        public int GetPerimeter()
        {
            int per;
            per = (width + length) * 2;
            return per;
        }
        public int GetArea()
        {
            int area;
            area = width * length;
            return area;
        }

    }
}
