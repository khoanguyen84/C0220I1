using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceDemo
{
    abstract class AbstractDemo
    {
        public int P1 { get; set; }

        public string Show()
        {
            return "show";
        }

        public virtual string Greeting()
        {
            return "Greeting";
        }

        public abstract string Info();
    }


    abstract class Person
    {
        public abstract string Greeting();
    }

    abstract class A
    {
        public abstract void AM();
    }

    abstract class B : A
    {
        public abstract void BM();
    }

    class C
    {
        public int P1 { get; set; }
        public void CM()
        {

        }
    }

    abstract class D : C
    {
        public abstract string DM();

        public string DM(string para1)
        {
            return para1;
        }

        public string DM(int para1)
        {
            return para1.ToString();
        }
        public string DM(int para1 , double para2)
        {
            return ((double)para1 + para2).ToString();
        }
    }
}
