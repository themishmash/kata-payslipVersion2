namespace Kata_PayslipAttempt2.Tests
{
    public class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        
        public int EmployeeId { get; set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

      
    }
}