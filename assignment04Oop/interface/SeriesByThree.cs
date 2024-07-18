using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment04Oop
{
    public class SeriesByThree : Iserias
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 3;
        }

        public void reset()
        {
            Current = 0;
        }
    }
}
