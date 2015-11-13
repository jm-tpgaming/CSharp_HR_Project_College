using System;

namespace Employee
{
    class Salaried : Employee
    {
        // Private Constants
        private const int MIN_MANAGEMENT_LEVEL = 0, MAX_MANAGEMENT_LEVEL = 3;
        private const double BONUS_PERCENT = .10, TAX_RATE = .73;

        
        //private variables
        private int managementLevel = MIN_MANAGEMENT_LEVEL;

        #region Constructors
        public Salaried() : base()
        {
            ManagementLevel = MIN_MANAGEMENT_LEVEL;
        }

        public Salaried(string employeeType) : base(employeeType)
        {
            ManagementLevel = MIN_MANAGEMENT_LEVEL;
        }
        public Salaried(string firstName, string lastName, char gender, int dependents, double annualSalary, Benefit benefits, int managementLevel)
            : base(firstName, lastName, gender, dependents, 0, "Salaried", benefits)
        {

        }
        #endregion

        #region Properties
        public int ManagementLevel
        {
            get 
            { 
                return managementLevel; 
            }
            set
            {
                if (value >= MIN_MANAGEMENT_LEVEL && value <= MAX_MANAGEMENT_LEVEL)
                    managementLevel = value;
                else if (value < MIN_MANAGEMENT_LEVEL)
                    managementLevel = MIN_MANAGEMENT_LEVEL;
                else
                    managementLevel = MAX_MANAGEMENT_LEVEL;
            }

        }
        #endregion

        public override double CalculateNetPay()
        {
            return CalculateWeeklyPay() * TAX_RATE;
        }

        public override double CalculateWeeklyPay()
        {

            return (base.AnnualSalary + base.AnnualSalary * managementLevel * BONUS_PERCENT) / 52;
        }

        public override string ToString()
        {
            string output;

            output = base.ToString();
            output += "\n\t           Level:\t" + ManagementLevel.ToString();

            return output;
        }
    }
}
