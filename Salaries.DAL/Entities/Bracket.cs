namespace Salaries.DAL.Entities
{
    /// <summary>
    /// Bracket class is the foundation for setting tax and tax credit brackets
    /// </summary>
    internal struct Bracket
    {
        /// <summary>
        /// Sets the higher threshold for the current tax bracket
        /// </summary>
        internal int Threshold { get; set; }
        /// <summary>
        /// Sets the tax rate for the current tax bracket
        /// </summary>
        internal double Rate { get; set; }
        /// <summary>
        /// Sets the cumulative amount for the current tax bracket (or the threshold of the previous tax bracket)
        /// </summary>
        internal int CumulativeAmount { get; set; }

        internal Bracket(int threshold, double rate, int cumulativeAmount)
        {
            Threshold = threshold;
            Rate = rate;
            CumulativeAmount = cumulativeAmount;
        }
    }
}
