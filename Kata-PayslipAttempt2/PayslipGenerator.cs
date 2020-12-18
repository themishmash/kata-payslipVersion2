using System;
using System.ComponentModel;

namespace Kata_PayslipAttempt2
{
    public class PayslipGenerator
    {
        private readonly IInputOutput _iio;
        public PayslipGenerator(IInputOutput iio)
        {
            
            _iio = iio;
        }

        // public SalaryDetails StartGettingSalaryInfo()
        // {
        //     // var name = _iio.AskQuestion("Please input your name: ");
        //     // var surname = _iio.AskQuestion("Please input your surname: ");
        //     var annualSalary = _iio.AskSalary("Please enter your salary: ");
        //     var super = _iio.AskSuper("Please enter your super rate: ");
        //     // var startDate = _iio.AskQuestion("Please enter your start date in format eg 1 March: ");
        //     // var endDate = _iio.AskQuestion("Please enter your end date in format eg 31 March: ");
        //     return new SalaryDetails(annualSalary, super);
        //    // var payslipCalculator = new PayslipCalculator(salaryDetails);
        //    // var employeeDetails = new EmployeeDetails(name, surname);
        //     //var timeConverter = new TimeConverter(startDate, endDate);
        //    // PrintDetails(employeeDetails, timeConverter, payslipCalculator);
        // }
        
        public void StartGettingSalaryInfo()
        {
            var name = _iio.AskQuestion("Please input your name: ");
            var surname = _iio.AskQuestion("Please input your surname: ");
            var annualSalary = _iio.AskSalary("Please enter your salary: ");
            var super = _iio.AskSuper("Please enter your super rate: ");
            var startDate = _iio.AskQuestion("Please enter your start date in format eg 1 March: ");
            var endDate = _iio.AskQuestion("Please enter your end date in format eg 31 March: ");
            var salaryDetails = new SalaryDetails(annualSalary, super);
            var payslipCalculator = new PayslipCalculator(salaryDetails);
            PrintDetails(name, surname, startDate, endDate, payslipCalculator);
        }

        private void PrintDetails(string name, string surname, string startDate, string endDate, PayslipCalculator payslipCalculator)
        {
            _iio.Output("Your payslip has been generated:");
            _iio.Output($"{name} {surname}");
            _iio.Output($"Pay Period {startDate} - {endDate}");
            _iio.Output($"Gross Income: {payslipCalculator.GetGrossIncome()}");
            _iio.Output($"Income Tax: {payslipCalculator.GetIncomeTax()}");
            _iio.Output($"Net Income: {payslipCalculator.GetNetIncome()}");
            _iio.Output($"Super: {payslipCalculator.GetSuper()}");
        }

        
    }
}