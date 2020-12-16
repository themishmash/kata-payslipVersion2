using System.Collections.Generic;
using System.Linq;

namespace Kata_PayslipAttempt2.Tests
{
    public class EmployeeRecord
    {

        private readonly List<Employee> _employees = new List<Employee>();
        private int _count;
        public Employee CreateEmployee(string name, string surname)
        {
            var employee = new Employee(name, surname) {EmployeeId = CreateEmployeeId()};
            _employees.Add(employee);
            return employee;
        }

        private int CreateEmployeeId()
        {
            _count++;
            return _count;
        }

        public Employee GetRecord(int employeeId)
        {
            return _employees.FirstOrDefault(employee => employee.EmployeeId == employeeId);
        }
    }
}