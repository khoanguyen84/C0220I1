using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
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
                },
                new Employee()
                {
                    AvatarPath = "images/nonavatar.png",
                    Department = Dept.HR,
                    Email = "hoang.phan@codegym.vn",
                    Id = 4,
                    Name = "Hoang"
                }
            );
        }

    }
}
