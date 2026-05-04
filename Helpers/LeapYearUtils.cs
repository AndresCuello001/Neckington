using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Helpers
{
    public class LeapYearUtils
    {

        public static int LeapYearDialog()
        {
            Console.Clear();
            Console.WriteLine("Write the year you want to evaluate");
            string year1 = Console.ReadLine() ?? "0";

            int year = int.Parse(year1);

            return year;
        }

        public static void GetLeapYearResult(int year) {
            
            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine($"{year} is a leap year? {isLeap}");

        }

        public static void InitializeLeapYear()
        {

            int dialogResult = LeapYearUtils.LeapYearDialog();
            LeapYearUtils.GetLeapYearResult(dialogResult);
        }


    }
}



       
