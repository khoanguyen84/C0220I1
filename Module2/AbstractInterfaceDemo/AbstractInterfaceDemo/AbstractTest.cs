using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceDemo
{
    class AbstractTest : AbstractDemo
    {
        public override string Info()
        {
            return "override from Abstract test class";
        }

        public override string Greeting()
        {
            return "Greeting override from AbstractTest";
        }
    }

    class Student : Person
    {
        public DateTime DoB { get; set; }
        public int Age => DateTime.Now.Year - DoB.Year;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";


        public override string Greeting()
        {
            return "I am a student";
        }
    }

    class Teacher : Person
    {
        public override string Greeting()
        {
            return "I am a teacher";
        }
    }

    class Test1 : B
    {
        public override void AM()
        {
            throw new NotImplementedException();
        }

        public override void BM()
        {
            throw new NotImplementedException();
        }
    }

    class Test2 : D, IFlyable, IEatable
    {
        public override string DM()
        {
            return "DM override from Abstract";
        }

        public void HowToFly()
        {
            throw new NotImplementedException();
        }

        public void HowToEat()
        {
            
        }
    }


    interface IEatable
    {
        void HowToEat();
    }

}
