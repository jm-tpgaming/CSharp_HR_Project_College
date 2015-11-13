using System;

namespace Employee
{
    public class ApplicationUtilities
    {
        public static void DisplayApplicationInformation()
        {
            Console.WriteLine("Welcome to the Basic Employee Program");
            Console.WriteLine("Name: Justin Eichenlaub");
            Console.WriteLine("This program accepts user input as a string, then makes the \nappropriate data conversion and assigns the value to Employee objects");
            Console.WriteLine();
        }
        public static void DisplayDivider(string outputTitle)
        {
            Console.WriteLine("\n********* " + outputTitle + " *********\n");
        }
        public static void TerminateApplication()
        {
            DisplayDivider("Program Termination");
            Console.Write("Thank you.  Press any key to terminate the program...");
            Console.ReadLine();
        }
        public static void PauseExecution()
        {
            Console.Write("\nProgram paused, press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
