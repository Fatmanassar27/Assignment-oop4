using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal interface ISeries
    {
        public int Current { get; set; }
        public void GetCurrent();
        public void RestCurrent()
         => Current = 0;
    }
}
