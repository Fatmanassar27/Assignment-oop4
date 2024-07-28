using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Shaps
{
    internal interface IShape
    {
        public double Area { get; set; }

        public void DisplayShapeInfo();
        
    }
}
