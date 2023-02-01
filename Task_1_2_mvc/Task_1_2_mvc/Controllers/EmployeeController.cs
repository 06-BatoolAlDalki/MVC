using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_1_2_mvc.Models;

namespace Task_1_2_mvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {

            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee { ID = 1, Name = "Batool", Major = "Network", Faculty = "JUST" });
            emp.Add(new Employee { ID = 2, Name = "Rama", Major = "Finace", Faculty = "Yurmouk" });

           
            return View(emp);
        }
    }
}