using System;

namespace AbstractInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractDemo abstractDemo = new AbstractDemo();
            AbstractTest abstractTest = new AbstractTest();
            Test2 test2 = new Test2();
            test2.DM();

            //IFlyable flyable = new IFlyable();
        }
    }
}
