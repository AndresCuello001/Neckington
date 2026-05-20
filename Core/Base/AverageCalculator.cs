using Neckington.Core.Configuration;
using Neckington.Helpers;
using Neckington.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Core.Base
{
   public class AverageCalculator: ProcessMessageUtils
   {
        public static void InitializeAverageCalculator()
        {
            AverageCalculator average = new AverageCalculator();
            average.ProcessData();
        }

        public override void ProcessData() {

            Console.WriteLine(Constants.AverageMenu);
            string n = Console.ReadLine() ?? "0";
           
            int numberOfArrays = int.Parse(n);
            int[] arrayNumbers = new int[numberOfArrays];

            CalculateAverage(arrayNumbers);        
        }

        public static void CalculateAverage(int[] arrayNumbers)
        {      
            try
            {
                AverageCalculatorUtils.GetCalculation(arrayNumbers);
            }
            catch (IndexOutOfRangeException e)
            { 
                Console.WriteLine("Error" + e.Message);
            }
        }     
   }
}
