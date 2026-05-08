using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Neckington.Helpers
{
    public class NumOrganizerUtils
    {
        public static void InitializeNumberOrganizer()
        {
            DisplayAndExtractData();
        }

        public static void DisplayAndExtractData()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your ordanizer number.... you're limited to 4 numbers ");
            Console.WriteLine("Please enter numbers that you want organize: ");
            string n = Console.ReadLine() ?? "0";

            int numberOfArrays = int.Parse(n);

            var listOfArrays = new List<int>(numberOfArrays);

            ResultOrganize(listOfArrays, numberOfArrays);
        }
  
        public static void ResultOrganize(List<int> listOfNumbers, int numberOfList) {

            try
            {
                ProcessNumOrganizerUtils.GetNumbers(listOfNumbers, numberOfList);
            }
           
            
            
            catch (Exception ex)
            {
                Console.WriteLine("Exception catched" + ex.Message);
            }

        }
    }
          
}
   
     


