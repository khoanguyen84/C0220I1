using System;

namespace PhoneManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            //for(int i = 0; i < 2; i++)
            //{
            //    Console.Write("Name: ");
            //    var name = Console.ReadLine();
            //    Console.Write("Phone number: ");
            //    var phoneNumber = Console.ReadLine();
            //    phoneBook.InsertPhone(name, phoneNumber);
            //}

            Console.Clear();
            phoneBook.Display();
            phoneBook.Sort();
            phoneBook.Display();
        }
    }
}
