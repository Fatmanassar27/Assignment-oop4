using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Shaps
{
    internal interface IRectangle : IShape
    {
        int Width { get; set; }
        int Height { get; set; }
    }
}
