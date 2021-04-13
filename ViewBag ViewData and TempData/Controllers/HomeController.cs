using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_ViewData_and_TempData.Models;

namespace ViewBag_ViewData_and_TempData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string err = "Hey, stop there you dummy";
            ViewData["Message"] = err;
            string[] fruits = { "apple", "banana", "mango", "guvava" };
            ViewData["Fruits"] = fruits;

            ViewData["SportsList"] = new List<string>()
            {
                "Circket",
                "Hockey",
                "Football",
                "Baseball"
            };
            Employee Ali = new Employee();
            Ali.EmpId = 1;
            Ali.EmpName = "Muhammad Ali";
            Ali.EmpDesignation = "Manager";

            ViewData["Ali"] = Ali;
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