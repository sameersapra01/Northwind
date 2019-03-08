using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class EmployeeTerritoriesController : Controller
    {
        // GET: EmployeeTerritories
        public ActionResult Index()
        {
            ModelContext modelContext = new ModelContext();
            List<EmployeeTerritories> employeeTerritories =  modelContext.EmployeeTerritories.ToList();

            return View();
        }
    }
}