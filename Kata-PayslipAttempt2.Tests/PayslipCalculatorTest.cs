using Xunit;

namespace Kata_PayslipAttempt2.Tests
{
    public class PayslipCalculatorTest
    {
        [Fact]
        public void Entering_Salary_Details_Returns_Gross_Income()
        {
            
            var mockSalaryDetails = new MockInput(60050, 9);
            var payslipGenerator = new PayslipGenerator(mockSalaryDetails);
            var salaryDetails = payslipGenerator.StartGettingSalaryInfo();
            var payslipCalculator = new PayslipCalculator(salaryDetails);

            Assert.Equal(5004, payslipCalculator.GetGrossIncome());
        }

        [Fact]
        public void Entering_Salary_Details_Returns_Income_Tax()
        {
            var mockSalaryDetails = new MockInput(60050, 9);
            var payslipGenerator = new PayslipGenerator(mockSalaryDetails);
            var salaryDetails = payslipGenerator.StartGettingSalaryInfo();
            var payslipCalculator = new PayslipCalculator(salaryDetails);
            
            Assert.Equal(922, payslipCalculator.GetIncomeTax());
        }

        [Fact]
        public void Entering_Salary_Details_Returns_Net_Income()
        {
            var mockSalaryDetails = new MockInput(60050, 9);
            var payslipGenerator = new PayslipGenerator(mockSalaryDetails);
            var salaryDetails = payslipGenerator.StartGettingSalaryInfo();
            var payslipCalculator = new PayslipCalculator(salaryDetails);
            
            Assert.Equal(4082, payslipCalculator.GetNetIncome());
        }

        [Fact]
        public void Entering_Salary_Details_Returns_Super()
        {
            var mockSalaryDetails = new MockInput(60050, 9);
            var payslipGenerator = new PayslipGenerator(mockSalaryDetails);
            var salaryDetails = payslipGenerator.StartGettingSalaryInfo();
            var payslipCalculator = new PayslipCalculator(salaryDetails);
            
            Assert.Equal(450, payslipCalculator.GetSuper());
        }
    }
}