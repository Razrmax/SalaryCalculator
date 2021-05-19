using Microsoft.AspNetCore.Mvc;
using NL_Net_Salary_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NL_Net_Salary_Calculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SalaryCalculator salaryCalc)
        {
            salaryCalc.CalculateGrossSalary();
            return View(salaryCalc);
        }
    }
}
