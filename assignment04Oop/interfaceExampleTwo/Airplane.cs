using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment04Oop.interfaceExampleTwo
{
    internal class Airplane : Vechile, IMoveable, IFlyable
    {
        public void Backward() // Implicitly
        {
            Console.WriteLine("Airplane move backward on ground");
        }

        void IMoveable.Forward() // Explicitly
        {
            Console.WriteLine("Airplane move forward on ground");
        }

        void IFlyable.Forward() //Explicitly
        {
            Console.WriteLine("Airplane move forward on air");
        }
    }
}
