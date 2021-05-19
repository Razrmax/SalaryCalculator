using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NL_Net_Salary_Calculator.Models
{
    public class SalaryCalculator
    {
        public double BaseHours { get; set; }
        public double OvertimeHours { get; set; }
        public double ShiftHours { get; set; }
        public double HolidayHours { get; set; }
        public double WeekendHours { get; set; }
        public TaxCredit TaxCredits {get ; private set;}
        public double NetSalary { get; private set; }
        public Salary Salaries { get; private set; }
        public ICredits ETCosts { get; private set; }
        public ICredits GeneralTaxCredits { get; private set; }
        public ICredits LaborTaxCredit { get; private set; }

        //public SalaryCalculator(double baseRate, double overtimeMultiplier, double shiftAllowance, double holidayMultiplier, double weekendMultiplier)
        //{
        //    Salaries = new Salary();
        //    Salaries.Rates.ElementAt(0).RateMultiplier = overtimeMultiplier;
        //    Salaries.ShiftAllowance = shiftAllowance;
        //    Salaries.HolidayMultiplier = holidayMultiplier;
        //    Salaries.WeekendMultiplier = weekendMultiplier;
        //    CalculateGrossSalary();
        //    TaxCredits = new TaxCredits(Salaries.GrossSalary);
        //}

        public SalaryCalculator()
        {
            Salaries = new Salary();
        }

        public void CalculateGrossSalary()
        {
            Salaries.GrossSalary = Salaries.BasePerHourRate * BaseHours + Salaries.BasePerHourRate * Salaries.Rates.ElementAt(0).RateMultiplier * OvertimeHours + Salaries.BasePerHourRate * Salaries.Rates.ElementAt(1).RateMultiplier * ShiftHours + Salaries.BasePerHourRate * Salaries.Rates.ElementAt(2).RateMultiplier * HolidayHours + Salaries.BasePerHourRate * Salaries.Rates.ElementAt(3).RateMultiplier * WeekendHours;
        }

        public void CalculateTaxCredits()
        {
            TaxCredits = new TaxCredit(Salaries.GrossSalary);
            ETCosts = new ExtraTerritorialCosts(Salaries.GrossSalary, 1552, 436);
        }

        public void CalculateDeductables()
        { 
        }
    }
}
