namespace Employee
{
    class Benefit
    {
        // Constants
        private const string DEFAULT_HEALTH_INSURANCE = "not given";
        private const double MIN_LIFE_INSURANCE = 0, MAX_LIFE_INSURANCE = 1000000;
        private const int MIN_VACATION = 0, MAX_VACATION = 45;

        // Private Variables
        private string healthInsuranceCompany;
        private double lifeInsuranceAmount;
        private int vacationDays;

        #region Constructors
        public Benefit()
        {
            healthInsuranceCompany = DEFAULT_HEALTH_INSURANCE;
            lifeInsuranceAmount = MIN_LIFE_INSURANCE;
            vacationDays = MIN_VACATION;
        }

        public Benefit(string healthInsuranceCompany, double lifeInsuranceAmount, int vacationDays)
        {
            HealthInsuranceCompany = healthInsuranceCompany;
            LifeInsuranceAmount = lifeInsuranceAmount;
            VacationDays = vacationDays;
        }
        #endregion 
        
        #region Properties
        // Here we setup the properties of the private variables so that data can be input
        public string HealthInsuranceCompany
        {
            get
            {
                return healthInsuranceCompany;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    healthInsuranceCompany = DEFAULT_HEALTH_INSURANCE;
                else
                    healthInsuranceCompany = value;
            }
        } // End of HealthInsuranceCompany public string

        public double LifeInsuranceAmount
        {
            get
            {
                return lifeInsuranceAmount;
            }
            set
            {
                if (value >= MIN_LIFE_INSURANCE && value <= MAX_LIFE_INSURANCE)
                    lifeInsuranceAmount = value;
                else if (value < MIN_LIFE_INSURANCE)
                    lifeInsuranceAmount = MIN_LIFE_INSURANCE;
                else
                    lifeInsuranceAmount = MAX_LIFE_INSURANCE;
            }
        } // End of LifeInsuranceAmount public double

        public int VacationDays
        {
            get
            {
                return vacationDays;
            }
            set
            {
                if (value >= MIN_VACATION && value <= MAX_VACATION)
                    vacationDays = value;
                else if (value < MIN_VACATION)
                    vacationDays = MIN_VACATION;
                else
                    vacationDays = MAX_VACATION;
            }
        } // End of VacationDays public int
        #endregion
        public override string ToString()
        {
            string output;

            output = "\n\t============ Benefit Information ============";
            output += "\nHealth Insurance Company:\t" + HealthInsuranceCompany;
            output += "\n   Life Insurance Amount:\t" + LifeInsuranceAmount.ToString("C2");
            output += "\n           Vacation Days:\t" + VacationDays;

            return output;
        }


    }
}
