using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Utilities
{
    public class LeapYearUtils
    {
        public static void InitializeLeapYear()
        {
            int dialogResult = ShowMessage();
            GetResult(dialogResult);
        }

        public static int ShowMessage()
        {
            Console.Clear();
            Console.WriteLine("Write the year you want to evaluate");
            string year1 = Console.ReadLine() ?? "0";

            int year = int.Parse(year1);

            return year;
        }

        public static void GetResult(int year) {
            
            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine($"{year} is a leap year? {isLeap}");

        }

      

    }
}



       
