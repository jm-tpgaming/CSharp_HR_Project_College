/* CIS247, Week 6 Lab
   Name: Justin Eichenlaub
   This program accepts user input as a string, then makes the 
   appropriate data conversion and assigns the value to the employee objects
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {


            ApplicationUtilities.DisplayApplicationInformation();           // Here we call the Methods from the ApplicationUtilities Class

            ApplicationUtilities.DisplayDivider("Start Program");

            Employee[] employeeList = new Employee[2];

            //employeeList[0] = new Employee();
            employeeList[0] = new Hourly("Hourly");
            employeeList[1] = new Salaried("Salaried");

            foreach (Employee emp in employeeList)
            {
                EmployeeInput.CollectEmployeeInformation(emp);

                if (emp is Hourly)
                {
                    EmployeeInput.CollectHourlyInformation((Hourly)emp);
                }
                else if (emp is Salaried)
                {
                    EmployeeInput.CollectSalaryInformation((Salaried)emp);
                }
                EmployeeOutput.DisplayEmployeeInformation(emp);
                ApplicationUtilities.PauseExecution();
            }
                EmployeeOutput.DisplayNumberObject();

                ApplicationUtilities.TerminateApplication();

                
        }
    }
}
