namespace Kata_PayslipAttempt2
{
    public class SalaryDetails
    {
        public int AnnualSalary { get; }
        public int GrossIncome { get; set; }
        public int IncomeTax { get; set; }
        public int NetIncome { get; set; }
        public double Super { get; set; }
        

        public SalaryDetails(int annualSalary, int super)
        {
            AnnualSalary = annualSalary;
            Super = super;

            // GrossIncome = PayslipCalculator.GetGrossIncome(annualSalary);
            // IncomeTax = PayslipCalculator.GetIncomeTax(annualSalary);
            // NetIncome = PayslipCalculator.GetNetIncome(annualSalary);
            // Super = PayslipCalculator.GetSuper(annualSalary, super);
        }
        
        
        
    }
}