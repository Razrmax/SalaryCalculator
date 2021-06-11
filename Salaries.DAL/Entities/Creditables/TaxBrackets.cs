using System.Collections.Generic;
using Salaries.DAL.Models;

namespace Salaries.DAL.Entities.Creditables
{
    public class TaxBrackets
    {
        internal Bracket LowerBracket { get; set; }
        internal Bracket HigherBracket { get; set; }
    }
}
