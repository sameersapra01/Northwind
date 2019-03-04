using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            ModelContext modelContext = new ModelContext();
            List<Employee> employees = modelContext.Employees.ToList();
            return View(employees);
        }


        // GET: Employee
        public ActionResult Details(int id)
        {
            ModelContext modelContext = new ModelContext();
            //List<Employee> employees =  modelContext.Employees;
            Employee employee = modelContext.Employees.Single(emp => emp.EmployeeID == id);

            return View(employee);
        }
    }
}