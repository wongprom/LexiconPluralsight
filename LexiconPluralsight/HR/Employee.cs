using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPluralsight.HR
{
    internal class Employee
    {
        public string firstName = string.Empty;
        public string lastName = string.Empty;
        public int numberOfHoursWorked = 0;
        public double wage;
        public double hourlyRate;
        public DateTime birthDay;
        public EmployeeType employeeType;

        // Static, Used on class level, not on instance/each object level.
        public static double taxRate = 0.15;

        const int MINIMAL_HOURS_WORKED_UNIT = 1;

        //Constructor
        public Employee(string first, string last, DateTime bd, double rate, EmployeeType empType)
        {
            firstName = first;
            lastName = last;
            birthDay = bd;
            hourlyRate = rate;
            employeeType = empType;
        }

        //Constructor overload (default values)
        public Employee(string first, string last, DateTime bd) : this(first, last, bd, 0, EmployeeType.StoreManager)
        {
        }

        //Methods
        public void PerformWork()
        {
            PerformWork(MINIMAL_HOURS_WORKED_UNIT);

        }
        //Overload Method
        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {

            if (numberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (numberOfHoursWorked > 10)
            {
                bonus *= 2;
            }
            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }
            Console.WriteLine($"The employee get a bonus of {bonus} ant the ta ont the bonus is {bonusTax}");
            return bonus;
        }

        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = 0.0;

            if (employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"AN etra was added to the wage since {firstName} is a manager!");
                wage = numberOfHoursWorked * hourlyRate * 1.25;
            }
            else
            {
                wageBeforeTax = numberOfHoursWorked * hourlyRate;
            }

            double taxAmount = wageBeforeTax * taxRate;
            wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hours of work.");
            if (resetHours)
            {
                numberOfHoursWorked = 0;
            }
            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Birthday: {birthDay.ToShortDateString()}");
            Console.WriteLine($"Hour Rate: {hourlyRate}");
            Console.WriteLine($"Tax Rate: {taxRate}");
        }





    }
}
