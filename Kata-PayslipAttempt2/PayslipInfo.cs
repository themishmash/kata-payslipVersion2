namespace Kata_PayslipAttempt2
{
    public class PayslipInfo
    {
        public readonly Employee Employee;
        public readonly string StartDate;
        public readonly string EndDate;
        public readonly PayslipCalculator PayslipCalculator;

        public PayslipInfo(Employee employee, string startDate, string endDate, PayslipCalculator payslipCalculator)
        {
            Employee = employee;
            StartDate = startDate;
            EndDate = endDate;
            PayslipCalculator = payslipCalculator;
        }
    }
}