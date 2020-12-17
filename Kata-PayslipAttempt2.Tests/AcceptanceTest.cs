using System;
using Xunit;

namespace Kata_PayslipAttempt2.Tests
{
    public class AcceptanceTest
    {
        [Fact]
        public void Entering_Details_Will_Generate_A_Payslip()
        {
            //var mockInput = new MockInput("John", "Doe", 60050, 9, "1 March", "31 March");
            
            //var payslipGenerator = new PayslipGenerator(new NullInputOutput());
            var mockSalaryDetails = new MockInput(60050, 9);
            var payslipGenerator = new PayslipGenerator(mockSalaryDetails);
            var salaryDetails = payslipGenerator.StartGettingSalaryInfo();
            var payslipCalculator = new PayslipCalculator(salaryDetails);

           // var salaryInfo = payslipGenerator.StartGettingSalaryInfo(60050, 9);
            //CreatePayslip will return new payslip object
            //call method to calc pay period, gross income, income tax, net income, super
            
            //assert amount is xx when call payslip.GrossIncome property
            
            Assert.Equal(5004, payslipCalculator.GetGrossIncome());
            Assert.Equal(922, payslipCalculator.GetIncomeTax());
            // Assert.Equal(4082, salaryInfo.GetNetIncome);
            // Assert.Equal(450, salaryInfo.Super);


        }
    }
}