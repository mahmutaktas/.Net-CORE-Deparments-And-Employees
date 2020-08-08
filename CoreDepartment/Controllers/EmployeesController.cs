using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CoreDepartment.Controllers
{
    public class EmployeesController : Controller
    {

        Context c = new Context();

        public IActionResult Index()
        {
            var list = c.employees.Include(x => x.depart).ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult NewEmployee()
        {

            List<SelectListItem> departs = (from x in c.departments.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.DepartmentName,
                                                Value = x.ID.ToString()

                                            }).ToList();

            ViewBag.departList = departs;
            
            return View();
        }

        [HttpPost]
        public IActionResult NewEmployee(Employee e)
        {
            var dep = c.departments.Where(x => x.ID == e.depart.ID).FirstOrDefault();
            e.depart = dep;
            c.employees.Add(e);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEmployee(int id)
        {

            var dep = c.employees.Find(id);
            c.employees.Remove(dep);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult GetEmployee(int id)
        {
            var emp = c.employees.Find(id);


            List<SelectListItem> departs = (from x in c.departments.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.DepartmentName,
                                                Value = x.ID.ToString()

                                            }).ToList();

            ViewBag.departList = departs;


            return View("GetEmployee", emp);
        }

        public IActionResult UpdateEmployee(Employee e)
        {
            var emp = c.employees.Find(e.ID);
            emp.EmpName = e.EmpName;
            emp.EmpLastname = e.EmpLastname;
            emp.EmpCity = e.EmpCity;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}