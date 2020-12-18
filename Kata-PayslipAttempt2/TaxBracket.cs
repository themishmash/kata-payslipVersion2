using System.Collections.Generic;
using System.Linq;

namespace Kata_PayslipAttempt2
{
    public class TaxBracket
    {
        public int TaxOnIncome { get; }
        public int LowerTaxableIncome { get; }
        public double TaxRate { get; }

        private TaxBracket(int taxOnIncome, int lowerTaxableIncome, double taxRate)
        {
            TaxOnIncome = taxOnIncome;
            LowerTaxableIncome = lowerTaxableIncome;
            TaxRate = taxRate;
        }

        private static readonly List<TaxBracket> TaxBrackets = new List<TaxBracket>()
        {
            new TaxBracket(54232, 180000, 0.45),
            new TaxBracket(19822, 87000, 0.37),
            new TaxBracket(3572, 37000, 0.325),
            new TaxBracket(0, 18200, 0.19),
            new TaxBracket(0, 0, 0)
        };
    
        public static TaxBracket GetTaxForAnnualSalary(int annualSalary)
        {
            return TaxBrackets.FirstOrDefault(taxBracket => annualSalary > taxBracket.LowerTaxableIncome);
        }
    }
}