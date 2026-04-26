using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington
{
    public class LeapYear
    {

        public static void DialogLeapYearCalculation()
        {
            Console.Clear();
            Console.WriteLine("Write the year you want to evaluate");
            string year1 = Console.ReadLine() ?? "0";

            int year = int.Parse(year1);

            bool esBisiesto = DateTime.IsLeapYear(year);
            Console.WriteLine($"{year} is a leap year? {esBisiesto}");
        }

     
    }
}



       
