using System;

namespace Employee
{
    class EmployeeOutput
    {
        public static void DisplayEmployeeInformation(Employee theEmployee)
        {
            ApplicationUtilities.DisplayDivider(theEmployee.EmployeeType);
            Console.WriteLine(theEmployee.ToString());
        }

        public static void DisplayNumberObject()
        {
            ApplicationUtilities.DisplayDivider("Number of Employees");
            Console.WriteLine("Number of Employees created: " + Employee.NumEmployees.ToString());
        }
    }
}
