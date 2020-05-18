using System;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleList list = new ExampleList();
            list.Display();

            Console.Write("Enter Name: ");
            var name = Console.ReadLine();
            var index = -1;
            var emp = list.Search(name, out index);
            if (emp != null)
            {
                list.Remove(emp);
            }

            if (index != -1)
            {
                list.RemoveAt(index);
            }
        }
    }
}
