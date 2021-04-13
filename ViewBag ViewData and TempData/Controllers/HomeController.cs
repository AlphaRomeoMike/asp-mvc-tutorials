using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ViewBag_ViewData_and_TempData.Models;

namespace ViewBag_ViewData_and_TempData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Message from ViewBag";
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();

            string[] dbs = { "mongodb", "oracle", "mssql", "mysql", "fedora" };
            ViewBag.Databases = dbs;

            ViewBag.Cars = new List<string>()
            {
                "Audi",
                "Ferreri",
                "Lamborghini",
                "Maserati",
                "Alfa Romeo"
            };

            Employee _1 = new Employee
            {
                EmpId = 2,
                EmpName = "Usman",
                EmpDesignation = "CEO"
            };

            ViewBag.Employee = _1;


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}