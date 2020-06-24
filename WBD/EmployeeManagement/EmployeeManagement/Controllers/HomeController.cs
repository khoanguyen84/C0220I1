using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public HomeController(IEmployeeRepository employeeRepository,
                            IWebHostEnvironment webHostEnvironment)
        {
            this.employeeRepository = employeeRepository;
            this.webHostEnvironment = webHostEnvironment;
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
            try
            {
                int.Parse(id.Value.ToString());
                var employee = employeeRepository.Get(id.Value);
                if (employee == null)
                {
                    //ViewBag.Id = id.Value;
                    return View("~/Views/Error/EmployeeNotFound.cshtml", id.Value);
                }
                var detailViewModel = new HomeDetailViewModel()
                {
                    Employee = employeeRepository.Get(id ?? 1),
                    TitleName = "Employee Detail"
                };
                return View(detailViewModel);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department
                };
                var fileName = string.Empty;
                if(model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                }
                employee.AvatarPath = fileName;
                var newEmp = employeeRepository.Create(employee);
                return RedirectToAction("Details", new { id = newEmp.Id});
            }
            return View();
        }

        public ViewResult Edit(int id)
        {
            var employee = employeeRepository.Get(id);
            if (employee == null)
            {
                return View("~/Views/Error/EmployeeNotFound.cshtml", id);
            }
            var empEdit = new HomeEditViewModel()
            {
                AvatarPath = employee.AvatarPath,
                Name = employee.Name,
                Email = employee.Email,
                Department = employee.Department,
                Id = employee.Id
            };
            return View(empEdit);
        }

        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department,
                    Id = model.Id,
                    AvatarPath = model.AvatarPath
                };
                var fileName = string.Empty;
                if (model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                    employee.AvatarPath = fileName;
                    if (!string.IsNullOrEmpty(model.AvatarPath))
                    {
                        string delFile = Path.Combine(webHostEnvironment.WebRootPath, 
                                            "images",model.AvatarPath);
                        System.IO.File.Delete(delFile);
                    }
                }

                var editEmp = employeeRepository.Edit(employee);
                if (editEmp != null)
                {
                    return RedirectToAction("Details", new { id = employee.Id });
                }
            }
            
            return View();
        }

        public IActionResult Delete(int id)
        {
            if (employeeRepository.Delete(id))
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
