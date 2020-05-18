using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDemo
{
    class LinkedListDemo
    {
        LinkedList<Employee> employees = new LinkedList<Employee>();
        Queue<Employee> emp = new Queue<Employee>();
        Stack<Employee> emps = new Stack<Employee>();

        SortedList<int, Employee> empss = new SortedList<int, Employee>();

        public void Init()
        {
            employees.AddFirst(new Employee() { });
            employees.AddAfter(employees.First, new Employee() { });
        }
    }
}
