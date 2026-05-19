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

namespace Neckington.Core
 {
   public class AverageCalculator: MessagesUtils
    {

        public static void InitializeAverageCalculator()
        {
            int[] dialogAverageResult = DisplayAndExtractData();
            GetAverage(dialogAverageResult);
        }

        public override int[] DisplayAndExtractData() {

            Console.WriteLine(Constants.AverageMenu);
            string n = Console.ReadLine() ?? "0";
            
            int numberOfArrays = int.Parse(n);

            int[] arrayNumbers = new int[numberOfArrays];
     
            return arrayNumbers;
        
        }

        public static void GetAverage(int[] arrayNumbers)
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
