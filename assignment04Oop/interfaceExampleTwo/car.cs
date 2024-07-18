using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment04Oop.interfaceExampleTwo
{
    internal class Car : Vechile, IMoveable
    {
        public void Backward()
        {
            throw new NotImplementedException();
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }
    }
}
