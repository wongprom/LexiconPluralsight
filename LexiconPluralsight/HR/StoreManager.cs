﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPluralsight.HR
{
    internal class StoreManager : Employee
    {
        public StoreManager(string firstName, string lastName, DateTime birthday, double? hourlyrate) : base(firstName, lastName, birthday, hourlyrate)
        {
        }
    }
}
