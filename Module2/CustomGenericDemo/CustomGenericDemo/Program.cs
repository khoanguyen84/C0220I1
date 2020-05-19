using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CustomGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //    MyGeneric<int> myGeneric = new MyGeneric<int>();
            //    myGeneric.Add(5);


            MyGeneric<User> myGeneric = new MyGeneric<User>();
            myGeneric.Add(new User() {
                Avatar = "avatar",
                Email = "khoa.nguyen@codegym.vn",
                Id = 1
            });

            for(int i = 0; i < myGeneric.Count; i++)
            {
                //Console.WriteLine(myGeneric.list[i].ToString());
                Console.WriteLine(myGeneric[i].ToString());
            }

            Console.WriteLine(myGeneric[3].ToString());
        }
    }
}
