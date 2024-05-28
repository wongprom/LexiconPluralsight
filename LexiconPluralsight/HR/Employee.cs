using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPluralsight.HR
{
    internal class Employee : IEmployee
    {
        public static double taxRate = 0.15;

        private string firstName = string.Empty;
        private string lastName = string.Empty;

        private int numberOfHoursWorked = 0;
        private double wage;
        private double? hourlyRate;

        private DateTime birthDay;

        const int MINIMAL_HOURS_WORKED_UNIT = 1;

        private Address adress;


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
          protected  set
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

        public Address Adress
        {
            get { return adress; }
            set
            {
                adress = value;
            }
        }
        //Constructor
        public Employee(string firstName, string lastName, DateTime birthday, double? hourlyrate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthday;
            HourlyRate = hourlyrate ?? 10;// if rate is null, set rate to 10
        }

        //Constructor overload (default values)
        public Employee(string firstName, string lastName, DateTime birthday) : this(firstName, lastName, birthday, 0)
        {
        }

        public Employee(string firstName, string lastName, DateTime birthday, double? hourlyrate, string street, string houseNumber, string zipCode, string city )
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthday;
            HourlyRate = hourlyrate ?? 10;// if rate is null, set rate to 10

            Adress = new Address(street, houseNumber, zipCode, city);

        }

        //Methods
        public void PerformWork()
        {
            PerformWork(MINIMAL_HOURS_WORKED_UNIT);

        }
        //Overload Method
        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {

            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (NumberOfHoursWorked > 10)
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

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} revived a generic bonus of 100!");
        }

        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {NumberOfHoursWorked} hours of work.");

            if (resetHours)
            {
                NumberOfHoursWorked = 0;
            }
            return Wage;
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First name: {FirstName}");
            Console.WriteLine($"Last name: {LastName}");
            Console.WriteLine($"Birthday: {BirthDay.ToShortDateString()}");
            Console.WriteLine($"Hour Rate: {HourlyRate}");
            Console.WriteLine($"Tax Rate: {taxRate}");
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You've done a great job, {FirstName}");
        }
    }
}
