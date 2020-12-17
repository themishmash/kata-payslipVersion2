using System;

namespace Kata_PayslipAttempt2
{
    public class PayslipCalculator
    {
        private static SalaryDetails _salaryDetails;

        public PayslipCalculator(SalaryDetails salaryDetails)
        {
            _salaryDetails = salaryDetails;
        }
        public int GetGrossIncome()
        {
            return _salaryDetails.AnnualSalary / 12;
        }

        public int GetIncomeTax()
        {
            var incomeTax = 0;
            var yearlyTaxAmount = 0;
            if (_salaryDetails.AnnualSalary <= 18200)
            {
                return incomeTax;
            }

            if (_salaryDetails.AnnualSalary >= 18201 && _salaryDetails.AnnualSalary <= 37000)
            {
                yearlyTaxAmount = (int) (Math.Ceiling((double) (_salaryDetails.AnnualSalary - 18200)) * .19);
            }

            if (_salaryDetails.AnnualSalary >= 37001 && _salaryDetails.AnnualSalary <= 87000)
            {
                yearlyTaxAmount = (int) (Math.Ceiling((double) (_salaryDetails.AnnualSalary - 37000)) *.325) + 3572;
            }
            
            if (_salaryDetails.AnnualSalary >= 87001 && _salaryDetails.AnnualSalary <= 180000)
            {
                yearlyTaxAmount = (int) (Math.Ceiling((double) (_salaryDetails.AnnualSalary - 87000)) * .37) + 19822;
            }

            if (_salaryDetails.AnnualSalary >= 180001)
            {
                yearlyTaxAmount = (int) (Math.Ceiling((double)(_salaryDetails.AnnualSalary - 180000)) * .45) + 54232;
            }
            
            incomeTax = (int) Math.Ceiling((double) yearlyTaxAmount /12);
            return incomeTax;
        }

        public int GetNetIncome()
        {
            return GetGrossIncome() - GetIncomeTax();
        }

        public int GetSuper()
        {
            double superDecimal = _salaryDetails.Super / 100;
            return (int) (GetGrossIncome() * superDecimal);
        }
    }
}