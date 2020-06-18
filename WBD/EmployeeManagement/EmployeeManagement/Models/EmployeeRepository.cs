using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee()
                {
                    AvatarPath = "images/nonavatar.png",
                    Department = Dept.IT,
                    Email = "khoa.nguyen@codegym.vn",
                    Id = 1,
                    Name = "Khoa" 
                },
                new Employee()
                {
                    AvatarPath = "images/nonavatar.png",
                    Department = Dept.HR,
                    Email = "phap.phan@codegym.vn",
                    Id = 2,
                    Name = "Pháp"
                }
            };
        }

        public Employee Create(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employee.AvatarPath = "images/nonavatar.png";
            employees.Add(employee);
            return employee;
        }

        public Employee Get(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
    }
}
