namespace Kata_PayslipAttempt2.Tests
{
    public class MockInput: IInputOutput
    {
        public int AnnualSalary { get; }
        public string Name { get; }
        public string Surname { get; }
        public int Salary { get; }
        public int Super { get; }
        public string StartDate { get; }
        public string EndDate { get; }

        public MockInput(string name, string surname, int salary, int super, string startDate, string endDate)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Super = super;
            StartDate = startDate;
            EndDate = endDate;
            
        }

        public MockInput(int annualSalary, int super)
        {
            AnnualSalary = annualSalary;
            Super = super;
        }

        public string AskQuestion(string question)
        {
            return "";
        }
    }
}