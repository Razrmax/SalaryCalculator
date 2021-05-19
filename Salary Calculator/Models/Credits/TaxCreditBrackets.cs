using System.Collections.Generic;

namespace NL_Net_Salary_Calculator.Models
{
    public struct TaxCreditBrackets
    {
        public static List<Bracket> Brackets { get; private set; }
        
        public TaxCreditBrackets(int taxCreditThreshold, double taxCreditRate, int cumulativeAmount)
        {
            Brackets = new List<Bracket>();
            Brackets.Add(new Bracket(taxCreditThreshold, taxCreditRate, cumulativeAmount));
        }

        public TaxCreditBrackets(List<Bracket> taxCreditBrackets)
        {
            Brackets = new List<Bracket>();
            Brackets.AddRange(taxCreditBrackets);
        }

        public void AddBracket(Bracket newBracket)
        {
            Brackets.Add(newBracket);
        }

        public void Add(List<Bracket> newBrackets)
        {
            Brackets.AddRange(newBrackets);
        }
    }
}
