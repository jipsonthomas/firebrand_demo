﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrands.Demos.Demo17_EntityFramework
{
    public partial class Employee
    {
        public string FullName
        {
            get
            {
                return FirstName + ' ' + LastName;
            }
        }
    }
}
