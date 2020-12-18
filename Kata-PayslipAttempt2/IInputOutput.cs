namespace Kata_PayslipAttempt2
{
    public interface IInputOutput
    {
        string AskQuestion(string question);

        int AskSalary(string question);

        int AskSuper(string question);

        void Output(string message);
    }
}