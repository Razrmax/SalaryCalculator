using System.Collections.Generic;

namespace NL_Net_Salary_Calculator.Models
{
    public class TaxBrackets
    {
        public static List<Bracket> Brackets { get; set; }
        public static Bracket LowerBracket { get; set; }
        public static Bracket HigherBracket { get; set; }
    }
}
