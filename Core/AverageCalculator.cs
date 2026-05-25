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
                AverageCalculator calculatorObject = new AverageCalculator();
                 int[] DataProcessed = calculatorObject.ProcessingData();
                 GetCalculation(DataProcessed);
            }
            catch (Exception ex) {
                Console.WriteLine("Error" + ex.Message);
            }
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
                Console.Write($"Introduce the element{i}: ");
                arrayNumbers[i] = int.Parse(Console.ReadLine() ?? "0");
                sum += arrayNumbers[i];
            }
                ShowResult(sum, arrayNumbers);
        }
   
        public int[] ProcessingData() 
        {
            Console.WriteLine(Constants.AverageMenu);
            string n = Console.ReadLine() ?? "0";

            int numberOfArrays = int.Parse(n);
            int[] arrayNumbers = new int[numberOfArrays];

            return arrayNumbers;
        }

        public static void ShowResult(int sum, int[] arrayNumbers)
        {
            double average = (double)sum / arrayNumbers.Length;
            Console.WriteLine("This is the average of your elements: " + average);
        }



    }
}
