using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPluralsight.HR
{
    internal class Developer : Employee
    {

        private string currentProject;

        public string CurrentProject
        {
            get { return currentProject; } 
            set 
            { 
                currentProject = value;            
            }
        }
        public Developer(string firstName, string lastName, DateTime birthday, double? hourlyrate) : base(firstName, lastName, birthday, hourlyrate)
        {
        }
    }
}
