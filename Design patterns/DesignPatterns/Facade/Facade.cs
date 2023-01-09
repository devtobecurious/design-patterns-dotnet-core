using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        SubsystemA a = new SubsystemA();
        SubsystemB b = new SubsystemB();
        SubsystemC c = new SubsystemC();

        public void Operation1()
        {
            Console.WriteLine("Operation 1 : " + a.A1() + a.A2() + b.B1());
        }

        public void Operation2()
        {
            Console.WriteLine("Operation 2 : " + b.B1() + c.C1());
        }
    }
}
