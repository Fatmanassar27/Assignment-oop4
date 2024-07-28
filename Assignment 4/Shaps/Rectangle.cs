using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Shaps
{
    internal class Rectangle : IRectangle
    {
        public int Width { get ; set ; }
        public int Height { get ; set ; }
        public double Area { get; set ; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
           
        }

        public Rectangle()
        {
            
        }
        public double fun ()
        {
            Area = Width * Height;
            return Area;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Width of Rectangle = {Width}     Height of Rectangle = {Height}    Area of Rectangle = {Area} ");
        }
    }
}
