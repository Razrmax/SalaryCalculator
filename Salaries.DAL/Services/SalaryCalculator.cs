using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salaries.DAL.Entities;
using Salaries.DAL.Entities.Creditables;
using Salaries.DAL.Entities.Deductables;
using Salaries.DAL.Entities.Persons;
using Salaries.DAL.Models;

namespace Salaries.DAL.Services
{
    public class SalaryCalculator
    {
        public double RegularHours { get; set; }
        public double HolidayHours { get; set; }
        public double WeekendHours { get; set; }
        public double LivingCosts { get; set; }
        public HoursCounter HoursCounter { get; private set; }
        public Salary Salary { get; }
        public IAmountable Tax { get; private set; }
        public IAmountable TaxCredits { get; private set; }
        internal IAmountable ETCosts { get; private set; }

        public SalaryCalculator()
        {
            Salary = new Salary();
            Tax = new Tax();
        }

        public void Calculate()
        {
            HoursCounter = new HoursCounter()
            {
                RegularHours = this.RegularHours,
                HolidayHours = this.HolidayHours,
                WeekendHours = this.WeekendHours,
            };
            HoursCounter.CalculateHours();
            CalculateGrossSalary();
            CalculateDeductables();
            CalculateNetSalary();
            CalculateTaxCredits();
        }

        internal void CalculateGrossSalary()
        {
            Salary.GrossSalary = Salary.BasePerHourRate * Salary.Rates.ElementAt(1).RateMultiplier * HoursCounter.RegularHours + 
                                 Salary.BasePerHourRate * Salary.Rates.ElementAt(0).RateMultiplier * HoursCounter.OvertimeHours + 
                                 Salary.BasePerHourRate * Salary.Rates.ElementAt(2).RateMultiplier * HoursCounter.HolidayHours + 
                                 Salary.BasePerHourRate * Salary.Rates.ElementAt(3).RateMultiplier * HoursCounter.WeekendHours;
        }

        internal void CalculateNetSalary()
        {
            Salary.NetSalary = Salary.GrossSalary - Tax.Amount;
        }

        internal void CalculateTaxCredits()
        {
            TaxCredits = new TaxCredit();
            TaxCredits.Calculate(Salary.GrossSalary);
            ETCosts = new ExtraTerritorialCosts(388, LivingCosts);
            ETCosts.Calculate(Salary.GrossSalary);
        }

        internal void CalculateDeductables()
        {
            Tax = new Tax();
            Tax.Calculate(Salary.GrossSalary);
        }
    }
}
