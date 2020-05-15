using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CollectionDemo
{
    class HashTableDemo
    {
        public Hashtable ht = new Hashtable();

        public void Show()
        {
            //ht.Add("1000100", "Vu");
            //ht.Add("2000100", "Duy");
            //ht.Add("3000100", "Hiep");
            //ht.Add("4000100", "Hiep");

            //foreach (var key in ht.Keys)
            //{
            //    Console.WriteLine(ht[key]);
            //}

            //foreach (var value in ht.Values)
            //{
            //    Console.WriteLine(value);
            //}

            ht.Add("11", new Product()
            {
                Id = 1,
                Name = "IP6S"
            });
            ht.Add("22", new Product()
            {
                Id = 4,
                Name = "IP7S"
            });
            ht.Add("33", new Product()
            {
                Id = 2,
                Name = "IP8S"
            });
            ht.Add("44", new Product()
            {
                Id = 3,
                Name = "IP9S"
            });

            foreach (var key in ht.Keys)
            {
                Console.WriteLine(ht[key].ToString());
            }

            //ht.ContainsKey("11");
            //ht.Remove("11");

            //foreach (var value in ht.Values)
            //{
            //    Console.WriteLine(value.ToString());
            //}

            //ht.Add("IP6", new List<Product>(){ 
            //    new Product()
            //    {
            //        Id =1,
            //        Name = "IP6"
            //    },
            //    new Product()
            //    {
            //        Id = 2,
            //        Name = "IP6S"
            //    },
            //    new Product()
            //    {
            //        Id = 3,
            //        Name = "IP6S Plus"
            //    }
            //});

            //foreach (List<Product> value in ht.Values)
            //{
            //    foreach(Product pdt in value)
            //    {
            //        Console.WriteLine(pdt.ToString());
            //    }
            //}

            //foreach (string key in ht.Keys)
            //{
            //    foreach (Product pdt in (List<Product>)ht[key])
            //    {
            //        Console.WriteLine(pdt.ToString());
            //    }
            //}
        }

        public class CustomSort : IComparer
        {
            public int Compare(object x, object y)
            {
                return ((Product)x).Id - ((Product)y).Id;
            }
        }

    }
}
