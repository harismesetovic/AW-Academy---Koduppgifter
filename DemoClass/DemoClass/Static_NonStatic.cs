using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    internal class Static_NonStatic
    {
        static public void StaticMethod()
        {
            Console.WriteLine("My name is StaticMethod()");
            Static_NonStatic instance = new Static_NonStatic();
            instance.NonStaticMethod();
        }

        public void NonStaticMethod()
        {
            Console.WriteLine("My name is NonStaticMethod()");
            StaticMethod();

        }
    }
}
