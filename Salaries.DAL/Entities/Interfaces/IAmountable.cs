using Salaries.DAL.Entities.Interfaces;

namespace Salaries.DAL.Models
{
    public interface IAmountable : ICalculatable
    {
        public double Amount { get; set; }
    }
}
