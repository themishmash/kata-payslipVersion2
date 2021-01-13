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
        
        public PayslipInfo StartGettingSalaryInfo()
        {
            var name = _iio.AskName("Please input your name: ");
            var surname = _iio.AskSurname("Please input your surname: ");
            var annualSalary = _iio.AskSalary("Please enter your salary: ");
            var super = _iio.AskSuper("Please enter your super rate: ");
            var startDate = _iio.AskStartDate("Please enter your start date in format eg 1 March: ");
            var endDate = _iio.AskEndDate("Please enter your end date in format eg 31 March: ");
            var employee = new Employee(name, surname);
            var salaryDetails = new SalaryDetails(annualSalary, super);
            var payslipCalculator = new PayslipCalculator(salaryDetails);
            return new PayslipInfo(employee, startDate, endDate, payslipCalculator);
            //PrintDetails(employee, startDate, endDate, payslipCalculator);
        }

        public void PrintDetails(PayslipInfo payslipInfo)
        {
            _iio.Output("Your payslip has been generated:");
            _iio.Output($"{payslipInfo.Employee.Name} {payslipInfo.Employee.Surname}");
            _iio.Output($"Pay Period {payslipInfo.StartDate} - {payslipInfo.EndDate}");
            _iio.Output($"Gross Income: {payslipInfo.PayslipCalculator.GetGrossIncome()}");
            _iio.Output($"Income Tax: {payslipInfo.PayslipCalculator.GetIncomeTax()}");
            _iio.Output($"Net Income: {payslipInfo.PayslipCalculator.GetNetIncome()}");
            _iio.Output($"Super: {payslipInfo.PayslipCalculator.GetSuper()}");
        }
        
    }
}