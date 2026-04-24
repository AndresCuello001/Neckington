using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington
{
    public class LeapYear
    {

        public LeapYear(int ParamNumberYear) {

            NumberYear = ParamNumberYear;

        }

        public static int DialogLeapYearCalculation()
        { 
            Console.Clear();
            Console.WriteLine("You have select the calculator of Leap-Year");
            Console.WriteLine("Please write the year you want to calculate: ");
            string entry1 = Console.ReadLine() ?? "0";
            
            int NumberYear = int.Parse(entry1);
          
            return NumberYear;
        }
        
        public static string YearCalculation(int NumberYear) 
        {
            if (NumberYear % 4 == 0 && NumberYear % 100 != 0 || NumberYear % 400 == 0) {
                  return "It's a leap year";
            }
            else
            { 
                return "Isn't a leap-year";
            }
            
        }

        private int NumberYear;
    }
}



       
