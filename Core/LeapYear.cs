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
        public override void GetData()
        {
            int year = ProcessData();
            GetResult(year);
        }
        public static int ProcessData()
        {
            Console.Clear();
            Console.WriteLine("Write the year you want to evaluate");
            string year1 = Console.ReadLine() ?? "0";

            int year = int.Parse(year1);
            return year;
        }
        public static void GetResult(int year) => DateTime.IsLeapYear(year);
    }      
}



       
