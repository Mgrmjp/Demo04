﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss()
        {
        }

        public override string ToString()
        {
            return base.ToString() + " > Car -- " + Car + " > Bonus -- " + Bonus;
        }
    }
}
