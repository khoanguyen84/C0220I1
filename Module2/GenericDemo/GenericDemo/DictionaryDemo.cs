using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    class DictionaryDemo
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        IDictionary<int, double> dic2 = new Dictionary<int, double>();
        Dictionary<int, Employee> emps;

        public DictionaryDemo()
        {
            emps = new Dictionary<int, Employee>();
            emps.Add(1, new Employee()
            {
                Email = "khoa@com",
                Id = 1,
                Name = "khoa"
            });
        }

        public void Show()
        {
            foreach(var key in emps.Keys)
            {
                Console.WriteLine(emps[key].Email);
            }

            foreach(var emp in emps.Values)
            {
                Console.WriteLine(emp.Email);
            }

            foreach(KeyValuePair<int, Employee> item in emps)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.Email);
            }
        }
    }
}
