using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        //Attribute router
        //[Route("~/")]
        //[Route("Home")]
        //[Route("Home/Index")]
        public ViewResult Index()
        {
            //ViewData["employees"] = employeeRepository.Gets();

            //ViewBag.employees = employeeRepository.Gets();
            var employees = employeeRepository.Gets();
            return View(employees);
        }

        public ViewResult Details(int? id)
        {
            //ViewBag.Employee = employeeRepository.Get(id);
            //var employee = employeeRepository.Get(id);
            //ViewBag.TitleName = "Employee Detail";
            var detailViewModel = new HomeDetailViewModel()
            {
                Employee = employeeRepository.Get(id??1),
                TitleName = "Employee Detail"
            };
            return View(detailViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                var newEmp = employeeRepository.Create(model);
                return RedirectToAction("Details", new { id = newEmp.Id });
            }
            return View();
        }
    }
}
