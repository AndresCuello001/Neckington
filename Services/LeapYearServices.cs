using Neckington.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Services
{
    public class LeapYearServices

    {
        public static void InitializeLeapYear()
        {
            int year = LeapYear.ProcessData();
            LeapYear.GetResult(year);
        }


    }
}
