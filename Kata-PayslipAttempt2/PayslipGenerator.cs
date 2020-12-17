using System;

namespace Kata_PayslipAttempt2
{
    public class PayslipGenerator
    {
       // public PayslipCalculator PayslipCalculator { get; }
        private readonly IInputOutput _iio;
        public PayslipGenerator(IInputOutput iio)
        {
            
            _iio = iio;
        }


        // public Payslip StartGettingSalaryInfo(int annualSalaryInt, int superInt)
        // {
        //     // var annualSalary = _iio.AskQuestion("What is your annual salary?");
        //     // var annualSalaryInt = int.Parse(annualSalary);
        //     // var super = _iio.AskQuestion("What is your super?");
        //     // var superInt = int.Parse(super);
        //     return new Payslip(annualSalaryInt, superInt);
        // }

        public SalaryDetails StartGettingSalaryInfo()
        {
            var annualSalary = _iio.AskQuestion("What is your annual salary?");
            var annualSalaryInt = int.Parse(annualSalary);
            var super = _iio.AskQuestion("What is your super?");
            var superInt = int.Parse(super);
            return new SalaryDetails(annualSalaryInt, superInt);
        }


        
    }
}