using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Fruit
    {
        public abstract void peel();

        public void eat()
        {
            peel(); // 皮をむく
            Console.WriteLine("食べる");
        }

    }
}
