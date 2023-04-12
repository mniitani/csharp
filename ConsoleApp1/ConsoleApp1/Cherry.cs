using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cherry : Fruit
    {
        public override void peel()
        {
            Console.WriteLine("皮が無いので何もしない");
        }
    }
}
