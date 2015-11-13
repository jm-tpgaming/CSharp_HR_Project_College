using System;

namespace Employee
{
    class Hourly : Employee
    {
        //Private Constants
        private const double MIN_WAGE = 10, MAX_WAGE = 75, MIN_HOURS = 0, MAX_HOURS = 50, TAX_RATE = 0.82;
        private const int NUMBER_WORK_WEEKS = 48;
        private const string DEFAULT_CATEGORY = "temporary";
        
        // variables
        double wage, hours;
        string category;


        #region Constructors
        public Hourly() : base()
        {
            Wage = MIN_WAGE;
            Hours = MIN_HOURS;
            Category = DEFAULT_CATEGORY;
        }

        public Hourly(string employeeType) : base(employeeType)
        {
            Wage = MIN_WAGE;
            Hours = MIN_HOURS;
            Category = DEFAULT_CATEGORY;
        }

        public Hourly(double wage, double hours, string category) : base()
        {
            Wage = wage;
            Hours = hours;
            Category = category;
        }

        public Hourly(string firstName, string lastName, char gender, int dependents, double wage, double hours, Benefit benefits, string category)
            : base(firstName, lastName, gender, dependents, 0, "Hourly", benefits)
        {
            Wage = wage;
            Hours = hours;
            Category = category;
        }

        
        #endregion

        #region Properties
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    category = DEFAULT_CATEGORY;
                }
                else
                {
                    string inValue = value.ToLower();

                    if (inValue == "temporary" || inValue == "part time" || inValue == "full time")
                    {
                        category = inValue;
                    }
                    else
                    {
                        category = DEFAULT_CATEGORY;
                    }
                }
            }
        }

        public double Hours
        {
            get { return hours; }
            set
            {
                if (value >= MIN_HOURS && value <= MAX_HOURS)
                    hours = value;
                else if (value < MIN_HOURS)
                    hours = MIN_HOURS;
                else
                    hours = MAX_HOURS;
                base.AnnualSalary = CalculateWeeklyPay() * NUMBER_WORK_WEEKS;
            }
        }

        public double Wage
        {
            get { return wage; }
            set
            {
                if (value >= MIN_WAGE && value <= MAX_WAGE)
                    wage = value;
                else if (value < MIN_WAGE)
                    wage = MIN_WAGE;
                else
                    wage = MAX_WAGE;
                base.AnnualSalary = CalculateWeeklyPay() * NUMBER_WORK_WEEKS;
            }
        }
        #endregion

        public override double CalculateNetPay()
        {
            return CalculateWeeklyPay() * TAX_RATE;
        }

        public override double CalculateWeeklyPay()
        {

            return wage * hours;
        }

        public override string ToString()
        {
            string output;

            output = base.ToString();
            output += "\n\t            Hours:\t" + Hours;
            output += "\n\t             Wage:\t" + Wage;
            output += "\n\t         Category:\t" + Category;

            return output;
        }
    }
}
