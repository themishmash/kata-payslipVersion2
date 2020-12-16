using Xunit;

namespace Kata_PayslipAttempt2.Tests
{
    public class EmployeeTest
    {
        [Fact]
        public void Can_Get_First_Name_From_Employee_Record()
        {
            var employeeRecord = new EmployeeRecord();
            employeeRecord.CreateEmployee("Michelle", "Wong");
            
            Assert.Equal("Michelle", employeeRecord.GetRecord(1).Name);
        }
    }
}