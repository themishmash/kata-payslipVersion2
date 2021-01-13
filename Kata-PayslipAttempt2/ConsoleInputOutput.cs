using System;

namespace Kata_PayslipAttempt2
{
    public class ConsoleInputOutput:IInputOutput
    {
        public string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public string AskName(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public string AskSurname(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public string AskStartDate(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public string AskEndDate(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public int AskSalary(string question)
        {
            Console.WriteLine(question);
            var answer = Console.ReadLine();
            int.TryParse(answer, out var salary);
            return salary;
        }

        public int AskSuper(string question)
        {
            Console.WriteLine(question);
            var answer = Console.ReadLine();
            int.TryParse(answer, out var super);
            return super;
        }

        public void Output(string message)
        {
            Console.WriteLine(message);
        }
    }
}