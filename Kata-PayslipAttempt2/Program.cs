using System;

namespace Kata_PayslipAttempt2
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleInputOutput = new ConsoleInputOutput();
            var payslipGenerator = new PayslipGenerator(consoleInputOutput);
            var paySlipInfo = payslipGenerator.StartGettingSalaryInfo();
            payslipGenerator.PrintDetails(paySlipInfo);

        }
    }
}