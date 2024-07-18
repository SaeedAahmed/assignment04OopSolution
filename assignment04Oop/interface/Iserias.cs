using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment04Oop
{
    public interface Iserias

    {
        public int Current { get; set; }
        public void GetNext();
        public void reset();
    }
}
