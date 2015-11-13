namespace Employee
{
    class EmployeeInput
    {
        public static void CollectEmployeeInformation(Employee theEmployee)
        {
            ApplicationUtilities.DisplayDivider("Collect " + theEmployee.EmployeeType + " information");
            theEmployee.FirstName = InputUtilities.getStringInputValue("First Name");
            theEmployee.LastName = InputUtilities.getStringInputValue("Last Name");
            theEmployee.Gender = InputUtilities.getCharInputValue("Gender");
            theEmployee.Dependents = InputUtilities.getIntegerInputValue("# Dependents");
            theEmployee.Benefits.HealthInsuranceCompany = InputUtilities.getStringInputValue(" Health Insurance Company: ");
            theEmployee.Benefits.LifeInsuranceAmount = InputUtilities.getDoubleInputValue(" Life Insurance Amount: ");
            theEmployee.Benefits.VacationDays = InputUtilities.getIntegerInputValue(" # Vacation Days: ");

        }

        public static void CollectHourlyInformation(Hourly theEmployee)
        {
            theEmployee.Wage = InputUtilities.getDoubleInputValue("Hourly Wage");
            theEmployee.Hours = InputUtilities.getDoubleInputValue("Hours Worked");
            theEmployee.Category = InputUtilities.getStringInputValue(" Category");

        }

        public static void CollectSalaryInformation(Salaried theEmployee)
        {
            theEmployee.ManagementLevel = InputUtilities.getIntegerInputValue("Management Level");
            theEmployee.AnnualSalary = InputUtilities.getDoubleInputValue("Annual Salary");
            
        }
    }
}
