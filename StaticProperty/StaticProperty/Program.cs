using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProperty
{
    class A
    {
        public static string property = Guid.NewGuid().ToString();
        public static string property2 = Guid.NewGuid().ToString();
        public static string property3 = Guid.NewGuid().ToString();
        public static string property4 = Guid.NewGuid().ToString();
        public static string property5 = Guid.NewGuid().ToString();
        public static string property6 = Guid.NewGuid().ToString();
    }

    class B : A
    {
        public void DoIt()
        {
            Console.WriteLine("ok");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(A.property);
            Console.WriteLine(A.property);
            Console.WriteLine(A.property);
            B b = new B();
            b.DoIt();
            A a = new A();
        }
    }
}
