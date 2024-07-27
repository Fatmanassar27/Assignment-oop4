using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal class Series : ISeries
    {
        public int Current { get; set; }

        public void GetCurrent()
        {
            Current += 2;

        }
       
    }
}
