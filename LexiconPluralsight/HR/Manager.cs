using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPluralsight.HR
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, DateTime birthday, double? hourlyrate) : base(firstName, lastName, birthday, hourlyrate)
        {
        }

        public void AttendManagementMeeting()
        {
            NumberOfHoursWorked += 10;
            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting that could have been an email");
        }

        public override void GiveBonus()
        {
            if ( NumberOfHoursWorked > 5 )
            {
                Console.WriteLine($"Manager {FirstName} {LastName} recived a magement bonus of 500!");
            }
            else
            {
                Console.WriteLine($"Manager {FirstName} {LastName} recived a magement bonus of 250!");

            }
        }
    }
}
