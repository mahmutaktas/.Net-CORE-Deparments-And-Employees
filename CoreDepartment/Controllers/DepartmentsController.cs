using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreDepartment.Models;

namespace CoreDepartment.Controllers
{
    public class DepartmentsController : Controller
    {

        Context c = new Context();

        public IActionResult Index()
        {
            var depts = c.departments.ToList();
            return View(depts);
        }

        [HttpGet]
        public IActionResult NewDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewDepartment(Department d)
        {
            c.departments.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDepartment(int id)
        {

            var dep = c.departments.Find(id);
            c.departments.Remove(dep);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult GetDepartment(int id)
        {
            var dep = c.departments.Find(id);

            return View("GetDepartment", dep);
        }

        public IActionResult UpdateDepartment(Department d)
        {
            var dep = c.departments.Find(d.ID);
            dep.DepartmentName = d.DepartmentName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}