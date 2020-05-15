using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;

namespace InheritDemo
{
    class Program : Object
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //a.AP1 = "A.p1";
            //a.AM1();


            //B b = new B();
            //b.AP1 = "B.P1";
            //b.AM1();
            //b.BP4 = "B.P4";
            //b.BM2();

            //C c = new C();
            //c.AP1 = "C.P1";
            //c.BP4 = "C.P4";
            //c.AM1();
            //c.BM2();

            //F1 f1 = new F1();
            //f1.M1();
            //f1.P1 = "F1";

            //F1.F2 f2 = new F1.F2();
            //f2.M1();
            //f2.M2();

            //A a = new A("khoa");

            //B b = new B("Vu", "Nhom");

            
            //Console.WriteLine(k2.Slogan());

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //K1 k1 = new K1();
            //Console.WriteLine(k1.ToString());

            K2 k2 = new K2();
            Console.WriteLine(k2.ToString());
        }
    }


    class A
    {
        public string AP1 { get; set; }
        protected string AP2 { get; set; }
        private int AP3;

        public A()
        {

        }

        public A(string ap1)
        {
            AP1 = ap1;
        }

        public void AM1()
        {

        }
    }

    class B : A
    {
        public string BP4 { get; set; }

        public B(string ap1, string bp4) : base(ap1)
        {
            BP4 = bp4;
        }

        public void BM2()
        {

        }
    }

    //class C : B
    //{

    //}

    class D : A
    {

    }

    class F1
    {
        public string P1 { get; set; }
        public void M1()
        {

        }

        public class F2 : F1
        {
            public string P2 { get; set; }

            public void M2()
            {

            }
        }
    }

    class K1 :Object
    {
        public string p1 { get; set; }
        public K1()
        {

        }

        public virtual string Slogan()
        {
            return "1 + 1 = 2";
        }

        public override string ToString()
        {
            return $"Từ K1: Chúng ta đang override phương thức ToString() của lớp Object";
        }
    }

    class K2 : K1
    {
        public K2()
        {

        }

        public override string Slogan()
        {
            return $"3 + 3 = 6";
        }

        public override string ToString()
        {
            return $"Từ K2: Chúng ta đang override phương thức ToString() của lớp Object";
        }
    }
}
