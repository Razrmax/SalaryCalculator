namespace Salaries.DAL.Entities
{
    public class Rate : Entity
    {
        public string RateName { get; private set; }
        public double RateMultiplier { get; private set; }

        public Rate(string rateName, double rateMultiplier)
        {
            RateName = rateName;
            RateMultiplier = rateMultiplier;
        }
    }
}