using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    class ListDemo
    {
        public List<int> ints = new List<int>();
        public List<Employee> employees = new List<Employee>() { 
            new Employee()
            {
                Email = "a",
                Id = 1,
                Name = "A"
            }
        };
        public List<Employee> emp;

        public ListDemo()
        {

            //dummy data
            emp = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Khoa",
                    Email = "Khoa.nguyen@c.com"
                }
            };
        }
        public void Show()
        {
            emp = new List<Employee>();
            emp.Add(new Employee());
            emp[0].Email = "b";
        }

        public override string ToString()
        {
            employees.Add(new Employee());
            employees[0].Email = "a";
            return "a";
        }

        public void Result()
        {
            Console.WriteLine(emp[0].Email);
            Console.WriteLine(employees[0].Email);
        }
    }


    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}";
        }
    }
}
