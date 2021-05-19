namespace NL_Net_Salary_Calculator.Models
{
    public struct Bracket
    {
        public int Threshold { get; set; }
        public double Rate { get; set; }
        public int CumulativeAmount { get; set; }

        public Bracket(int threshold, double rate, int cumulativeAmount)
        {
            Threshold = threshold;
            Rate = rate;
            CumulativeAmount = cumulativeAmount;
        }
    }
}
