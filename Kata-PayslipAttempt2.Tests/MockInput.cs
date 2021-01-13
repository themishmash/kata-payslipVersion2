namespace Kata_PayslipAttempt2.Tests
{
    public class MockInput: IInputOutput
    {
        public int Salary { get; set; }
        public int Super { get; set; }
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        // public MockInput(string name, string surname, string startDate, string endDate, int salary, int super )
        // {
        //     
        //     Name = name;
        //     Surname = surname;
        //     StartDate = startDate;
        //     EndDate = endDate;
        //     Salary = salary;
        //     Super = super;
        // }

        public string AskQuestion(string question)
        {
            return "";
        }

        public string AskName(string question)
        {
            return "John";
        }

        public string AskSurname(string question)
        {
            return "Doe";
        }

        public string AskStartDate(string question)
        {
            return "1 March";
        }

        public string AskEndDate(string question)
        {
            return "31 March";
        }

        public int AskSalary(string question)
        {
            return 60050;
        }

        public int AskSuper(string question)
        {
            return 9;
        }

        public void Output(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}