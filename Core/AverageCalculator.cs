using Neckington.Core.Base;
using Neckington.Core.Configuration;
using Neckington.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Core
{
   public class AverageCalculator: BaseAction
   {
        public static void ProcessData()
        {
            try
            {
                StartAverageCalculator();
            }
            catch (Exception ex) {
                Console.WriteLine("Error" + ex.Message);
            }
        }

        public static void StartAverageCalculator()
        {

            AverageCalculator calculatorObject = new AverageCalculator();
            int[] DataProcessed = calculatorObject.ProcessingData();
            GetCalculation(DataProcessed);
        }

        public static void GetCalculation(int[] arrayNumbers)
        {
            int sum = 0;
            ExecuteCalculation(sum, arrayNumbers);
        }

        public static void ExecuteCalculation(int sum, int[] arrayNumbers)
        {
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = InputHelper.ReadInt($"Introduce the element [{i}]");
                sum += arrayNumbers[i];
            }
              AverageCalculator averageResultObject = new AverageCalculator();    
               averageResultObject.ShowResult(sum, arrayNumbers);
        }
   
        public int[] ProcessingData() 
        {
            
            string n = InputHelper.ReadRequiredString(Constants.AverageMenu);
            int numberOfArrays = InputHelper.ReadInt(n);
            int[] arrayNumbers = new int[numberOfArrays];

            return arrayNumbers;
        }

        public override void ShowResult(int sum, int[] arrayNumbers)
        {
            double average = (double)sum / arrayNumbers.Length;
            Console.WriteLine("This is the average of your elements: " + average);
        }
   }
}
