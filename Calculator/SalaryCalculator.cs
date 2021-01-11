using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;
        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            
            decimal annualSalary = hourlyWage * HoursInYear;
            return annualSalary;
        }
        // Example using lambda =>
        public decimal GetHourlyWage(int annualSalary) => annualSalary / HoursInYear;
        
    }
}
