using System;
using Xunit;

namespace Kata_PayslipAttempt2.Tests
{
    public class AcceptanceTest
    {
        [Fact]
        public void Entering_Details_Will_Generate_A_Payslip()
        {
            var employeeRecord = new EmployeeRecord();
            var employee = employeeRecord.CreateEmployee("Michelle", "Wong");
            
           
            


        }
    }
}