using System;

namespace Kata_PayslipAttempt2
{
    public class PayslipCalculator
    {
        private SalaryDetails _salaryDetails { get; }

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
            var tax = TaxBracket.GetTaxForAnnualSalary(_salaryDetails.AnnualSalary);
            return (int) Math.Ceiling((_salaryDetails.AnnualSalary - tax.LowerTaxableIncome) * tax.TaxRate +
                   tax.TaxOnIncome) / 12;
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