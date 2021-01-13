namespace Kata_PayslipAttempt2
{
    public interface IInputOutput
    {
        string AskName(string question);
        
        string AskSurname(string question);
        
        string AskStartDate(string question);
        
        string AskEndDate(string question);

        int AskSalary(string question);

        int AskSuper(string question);

        void Output(string message);
    }
}