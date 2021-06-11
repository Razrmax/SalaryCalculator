using Salaries.DAL.Entities.Interfaces;

namespace Salaries.DAL.Entities.Persons
{
    public class HoursCounter : Entity
    {
        /// <summary>
        /// Threshold of hours after which the overtime starts, 40 by default
        /// </summary>
        public double OvertimeThreshold { get; private set; }

        public double RegularHours { get; set; }
        public double OvertimeHours { get; set; }
        public double WeekendHours { get; set; }
        public double HolidayHours { get; set; }

        public HoursCounter()
        {
        }

        public void CalculateHours()
        {
            OvertimeThreshold = 40;

            if (RegularHours > OvertimeThreshold)
            {
                RegularHours = OvertimeThreshold;
                OvertimeHours = RegularHours - OvertimeThreshold;
            }
            else
            {
                OvertimeHours = 0;
            }
        }
    }
}