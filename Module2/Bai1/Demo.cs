using System;
namespace Bai1
{
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Khoa Nguyen");
            Console.Write("Input your email: ");
            var email = Console.ReadLine();


            Console.WriteLine("Your email is: " + email);
            Console.WriteLine(String.Format("Your email is {0}", email));
            Console.WriteLine($"Your email is {email}");

            Console.ReadKey();
        }
    }
}