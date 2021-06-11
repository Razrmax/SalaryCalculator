using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salaries.DAL.Data;
using Salaries.DAL.Services;

namespace Salaries.WEB.Controllers
{
    public class HomeController : Controller
    {
        private SalariesDbContext Context { get; }

        public HomeController(SalariesDbContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(SalaryCalculator salaryCalc)
        {
            salaryCalc.Calculate();
            Context.Salaries.Add(salaryCalc.Salary);
            Context.SaveChanges();
            return View(salaryCalc);
        }
    }
}
