using System.Collections.Generic;
using Salaries.DAL.Models;

namespace Salaries.DAL.Entities.Creditables
{
    public struct TaxCreditBrackets
    {
        internal List<Bracket> Brackets { get; private set; }
        
        internal TaxCreditBrackets(List<Bracket> taxCreditBrackets)
        {
            Brackets = new List<Bracket>();
            Brackets.AddRange(taxCreditBrackets);
        }

        internal void AddBracket(Bracket newBracket)
        {
            Brackets.Add(newBracket);
        }

        internal void Add(List<Bracket> newBrackets)
        {
            Brackets.AddRange(newBrackets);
        }
    }
}
