using System;

namespace Kata_PayslipAttempt2
{
    public class PayslipCalculator
    {
        private SalaryDetails SalaryDetails { get; }

        public PayslipCalculator(SalaryDetails salaryDetails)
        {
            SalaryDetails = salaryDetails;
        }
        public int GetGrossIncome()
        {
            return SalaryDetails.AnnualSalary / 12;
        }

        public int GetIncomeTax()
        {
            var tax = TaxBracket.GetTaxForAnnualSalary(SalaryDetails.AnnualSalary);
            return (int) Math.Ceiling((SalaryDetails.AnnualSalary - tax.LowerTaxableIncome) * tax.TaxRate +
                   tax.TaxOnIncome) / 12;
        }

        public int GetNetIncome()
        {
            return GetGrossIncome() - GetIncomeTax();
        }

        public int GetSuper()
        {
            var superDecimal = SalaryDetails.Super / 100;
            return (int) (GetGrossIncome() * superDecimal);
        }
    }
}