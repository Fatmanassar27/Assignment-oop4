using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal class Aroplane : Vechile, IMovable, IFlyable
    {
        public void Borward()
        {
            Console.WriteLine("Aroplane move backword");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("Aroplane move backword on the Gorund");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Aroplane move backword on the air");
        }

        void IMovable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
