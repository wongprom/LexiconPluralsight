using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPluralsight.HR
{
    internal class Researcher : Employee
    {
        //Field
        private int numberOfPieTastesInvented = 0;
        //Property
        public int NumberOfPieTastesInvented
        {
            get
            {
                return numberOfPieTastesInvented;
            }
            private set
            {
                numberOfPieTastesInvented = value;
            }
        }
        //Constructor
        public Researcher(string firstName, string lastName, DateTime birthday, double? hourlyrate) : base(firstName, lastName, birthday, hourlyrate)
        {
        }

        //Method
        public void ResearcherNewPieTastes(int researchHours)
        {
            NumberOfHoursWorked += researchHours;

            if(new Random().Next(100)>50)
            {
                NumberOfPieTastesInvented++;
                Console.WriteLine($"Researcher {FirstName} {LastName} has invvented a new pie taste! Total number of pies invented: {NumberOfPieTastesInvented}");
            }
            else
            {
                Console.WriteLine($"Researcher {FirstName} {LastName} is still working on a new pie taste!");

            }
        }
    }
}
