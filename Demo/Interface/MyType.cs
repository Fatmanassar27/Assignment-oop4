using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal class MyType : IType
    {
        public int Id { get ; set ; }

        public void MyFun(int X)
        {
            ;Console.WriteLine($"X = {X}   ID = {Id}");
        }
    }
}
