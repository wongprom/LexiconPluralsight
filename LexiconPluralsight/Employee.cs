using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPluralsight
{
    internal class Employee
    {
        public string firstName = String.Empty;
        public string lastName = String.Empty;
        public double numberOfHoursWorked;
        public double wage;
        public double hourlyWage;
        public DateTime birthDay;

        const int MINIMAL_HOURS_WORKED_UNIT = 1;

        //Methods
        public void PerformWork()
        {
            PerformWork(MINIMAL_HOURS_WORKED_UNIT);
        }
        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyWage;
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hours of work.");
            if (resetHours)
            {
                numberOfHoursWorked = 0;
            }
            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.Write($"First name: {firstName}");
            Console.Write($"Last name: {lastName}");
            Console.Write($"Birthday: {birthDay.ToShortDateString()}");
        }

        //Overload Method
        public void PerformWork(int numberOfHoursWorked)
        {
            numberOfHoursWorked += numberOfHoursWorked;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour (s)!");
        }

        
    }
}
