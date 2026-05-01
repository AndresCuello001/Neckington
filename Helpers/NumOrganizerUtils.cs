using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Neckington.Helpers
{
    public class NumOrganizerUtils
    {
        public static int[] NumOrganizerMethod()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your ordanizer number.... you're limited to 4 numbers ");
            Console.WriteLine("Please enter numbers that you want organize: ");
            string n = Console.ReadLine() ?? "0";
            int numberOfArrays = int.Parse(n);

            int[] arrayOrganizer = new int[numberOfArrays];

            return arrayOrganizer;
        }
        
        public static void GetNumberOrganize(int [] ParamArrayOrganizer)
        {   
            for (int i = 0; i < ParamArrayOrganizer.Length ; i++)
            {
                try
                {
                    Console.Write($"Introduce the element{i}: ");
                    ParamArrayOrganizer[i] = int.Parse(Console.ReadLine() ?? "0");
                }
                catch(Exception ex) {
                    Console.WriteLine("Exception catched" + ex.Message );
                }
            }
               Array.Sort(ParamArrayOrganizer);
               Console.WriteLine("Your numbers: " + string.Join(", ", ParamArrayOrganizer));

             
        }
        
    }
}
   
     


