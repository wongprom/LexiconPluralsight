using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPluralsight
{
    internal class Utilities
    {
        public static int CalculateYearlyWage(int amount, int months, int bonus = 0)
        {
            return amount * months + bonus;
        }
    }
}
