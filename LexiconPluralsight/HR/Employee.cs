using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPluralsight.HR
{
    internal class Employee
    {
        public static double taxRate = 0.15;

        private string firstName = string.Empty;
        private string lastName = string.Empty;

        private int numberOfHoursWorked = 0;
        private double wage;
        private double? hourlyRate;

        private DateTime birthDay;
        private EmployeeType employeeType;


        const int MINIMAL_HOURS_WORKED_UNIT = 1;

        // Property
        public string FirstName
        { 
            get { return firstName; }
            set 
            { 
                firstName = value; 
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }
        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
          private  set
            {
                numberOfHoursWorked = value;
            }
        }  
        public double Wage
        {
            get { return wage; }
           private set
            {
                wage = value;
            }
        }    
        public double? HourlyRate
        {
            get { return hourlyRate; }
            set
            {

                if (hourlyRate > 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                hourlyRate = value;
                }
            }
        }
        public DateTime BirthDay
        {
            get { return birthDay; }
            set
            {
                birthDay = value;
            }
        }
        public EmployeeType EmployeeType
        {
            get { return employeeType; }
            set
            {
                employeeType = value;
            }
        }

        //Constructor
        public Employee(string first, string last, DateTime bd, double? rate, EmployeeType empType)
        {
            firstName = first;
            lastName = last;
            birthDay = bd;
            hourlyRate = rate ?? 10;// if rate is null, set rate to 10
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
                wageBeforeTax = numberOfHoursWorked * hourlyRate.Value * 1.25;
            }
            else
            {
                wageBeforeTax = numberOfHoursWorked * hourlyRate.Value;
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

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
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
