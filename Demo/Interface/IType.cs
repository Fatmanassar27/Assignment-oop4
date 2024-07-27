using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal interface IType
    {
        public int Id { get; set; }

        public void MyFun (int X);

        public void Print ()
        {
            Console.WriteLine($"Hello Route");
        }
    }
}
