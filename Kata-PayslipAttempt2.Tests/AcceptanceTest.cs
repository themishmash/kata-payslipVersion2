using System;
using Xunit;

namespace Kata_PayslipAttempt2.Tests
{
    public class AcceptanceTest
    {
        [Fact]
        public void Entering_Details_Will_Generate_A_Payslip()
        {
          
            var mockInput = new MockInput();
            var payslipGenerator = new PayslipGenerator(mockInput);
            var paySlipInfo = payslipGenerator.StartGettingSalaryInfo();
            
           Assert.Equal(5004, paySlipInfo.PayslipCalculator.GetGrossIncome());
           Assert.Equal(922, paySlipInfo.PayslipCalculator.GetIncomeTax());
           Assert.Equal(4082, paySlipInfo.PayslipCalculator.GetNetIncome());
           Assert.Equal(450, paySlipInfo.PayslipCalculator.GetSuper());
           Assert.Equal("John", paySlipInfo.Employee.Name);

        }
    }
}