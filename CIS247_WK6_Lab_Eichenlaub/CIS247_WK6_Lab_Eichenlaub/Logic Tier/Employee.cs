namespace Employee
{
    abstract class Employee
    {
        // Private Parameters
        protected string firstName = "not given", lastName = "Not given";
        protected char gender = 'U';
        protected int dependents = 0;
        protected double annualSalary = 20000;
        protected static int numEmployees = 0;
        protected string employeeType;

        // Constants
        private const double MIN_SALARY = 20000;
        private const double MAX_SALARY = 100000;
        private const string DEFAULT_NAME = "Not given";
        private const char DEFAULT_GENDER = 'U';
        private const int MIN_DEPENDENTS = 0;
        private const int MAX_DEPENDENTS = 10;
        private const string DEFAULT_EMPLOYEE = "Generic Employee";

        // Here is a call to the Benefit class so the output can be added to the ToString public override
        protected Benefit benefits;

        


        #region Constructors
        public Employee()
        {
            EmployeeType = DEFAULT_EMPLOYEE;
            benefits = new Benefit(); //Instantiates the Benefit class 
            numEmployees++;
        }
        
        public Employee(string firstName, string lastName, char gender, int dependents, double annualSalary, string employeeType, Benefit benefits)
        {
            FirstName = firstName;             //Here we setup the overloaded constructor 
            LastName = lastName;
            Gender = gender;
            Dependents = dependents;
            AnnualSalary = annualSalary;
            Benefits = benefits; //Adding the Benefits argument 
            numEmployees++;
        }

        public Employee(string employeeType) : this()
        {
            EmployeeType = employeeType;
        }

        // Here is our abstract method CalculateNetPay
        public abstract double CalculateNetPay();
        

        #endregion 

        #region Properties
        public string EmployeeName
        {
            get
            {
                return FirstName + "" + LastName;
            }
        }

        public string EmployeeType
        {
            get
            {
                return employeeType;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    employeeType = DEFAULT_EMPLOYEE;
                else
                    employeeType = value;
            }
        }

        public virtual double CalculateWeeklyPay()
        {
            return AnnualSalary / 52.0;
        }

        public double CalculateWeeklyPay(double employeeSalary)
        {
            AnnualSalary = employeeSalary;
            return CalculateWeeklyPay();
        }

        public static int NumEmployees
        {
            get { return numEmployees; }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    firstName = DEFAULT_NAME;
                else
                    firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    lastName = DEFAULT_NAME;
                else
                    lastName = value;
            }
        }

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'f' || value == 'F' || value == 'm' || value == 'M')
                    gender = value;
                else
                    gender = DEFAULT_GENDER;
            }
        }

        public int Dependents
        {
            get { return dependents; }
            set
            {
                if (value >= MIN_DEPENDENTS && value <= MAX_DEPENDENTS)
                    dependents = value;
                else if (value < MIN_DEPENDENTS)
                    dependents = MIN_DEPENDENTS;
                else
                    dependents = MAX_DEPENDENTS;

            }
        }

        public double AnnualSalary
        {
            get { return annualSalary; }
            set
            {
                if (value >= MIN_SALARY && value <= MAX_SALARY)
                    annualSalary = value;
                else if (value < MIN_SALARY)
                    annualSalary = MIN_SALARY;
                else
                    annualSalary = MAX_SALARY;

            }
        }

        public Benefit Benefits
        {
            get { return benefits; }
            set
            {
                if (value == null)
                    benefits = new Benefit();
                else
                    benefits = value;
            }
        } 
        #endregion

        public override string ToString()
        {
            string output;

            output = "============ Employee Information ============\n";
            output += "\n\t            Type:\t" + EmployeeType;
            output += "\n\t            Name:\t" + firstName + " " + lastName;
            output += "\n\t          Gender:\t" + gender;
            output += "\n\t      Dependents:\t" + Dependents;
            output += "\n\t   Annual Salary:\t" + AnnualSalary.ToString("C2");
            output += "\n\t      Weekly Pay:\t" + CalculateWeeklyPay().ToString("C2");
            output += "\n\t   Net Pay:\t" + CalculateNetPay().ToString("C2");
            output += Benefits.ToString();

            return output;
        }
    }
}
