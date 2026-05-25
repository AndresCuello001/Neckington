using Neckington.Core.Base;
using Neckington.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Core
{
    public class LeapYear : BaseAction
    {
      
        public static int ProcessData()
        {
            Console.Clear();
            string year1 = InputHelper.ReadRequiredString("Write the year you want to evaluate");

            int year = int.Parse(year1);
            return year;
        }
        public static void GetResult(int year) => DateTime.IsLeapYear(year);
    }      
}



       
