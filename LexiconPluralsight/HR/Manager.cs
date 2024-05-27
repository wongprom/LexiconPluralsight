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
    }
}
