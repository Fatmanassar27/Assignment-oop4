using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Shaps
{
    internal class Circle : ICircle
    {
        public int Redeus { get ; set; }
        public double Area { get; set; }

        public Circle(int redeus)
        {
            Redeus = redeus;
        }

        public double fun ()
        { 
            Area = Redeus * Redeus * 3.14;
            return Area;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Redeus of Circle = {Redeus}      Area of Circle = {Area} ");
        }
    }
}
