using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using static CollectionDemo.HashTableDemo;

namespace CollectionDemo
{
    class ArrayListDemo
    {
        public ArrayList al = new ArrayList();
        public void Test()
        {
            //al.Add(1);
            //al.Add('c');
            //al.Add(6.7);
            //al.Add(true);
            //al.Add(new Product()
            //{
            //    Id = 1,
            //    Name = "IP6S"
            //});
            //al.Add("C0220a");
            //al.Add("C0220b");
            //al.Add("C0220c");
            //al.Add("C0220d");

            //foreach (var item in al)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine($"Capacity: {al.Capacity}");

            //al.Remove('c');
            //al.RemoveAt(1);

            //foreach (var item in al)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            al.Add(new Product()
            {
                Id = 1,
                Name = "IP6S"
            });
            al.Add(new Product()
            {
                Id = 4,
                Name = "IP7S"
            });
            al.Add(new Product()
            {
                Id = 2,
                Name = "IP8S"
            });
            al.Add(new Product()
            {
                Id = 3,
                Name = "IP9S"
            });
            al.Sort(new CustomSort());
            foreach (var item in al)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
