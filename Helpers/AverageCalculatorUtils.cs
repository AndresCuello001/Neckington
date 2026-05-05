using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Helpers
 {
   public class AverageCalculatorUtils
    {

        public static void InitializeAverageCalculator()
        {

            int[] dialogAverageResult = AverageCalculatorUtils.AverageDialog();
            AverageCalculatorUtils.ArrayCalculation(dialogAverageResult);

        }

        public static int[] AverageDialog() {

            Console.Clear();
            Console.WriteLine("You have select the PromCalculator: ");

            Console.WriteLine("Write down How many numbers you wanna calculate: ");
            string n = Console.ReadLine() ?? "0";
            int numberOfArrays = int.Parse(n);

            int[] arrayNumbers = new int[numberOfArrays];
            return arrayNumbers;
        
        }

        public static void GetAverage(int[] arrayNumbers){  
            
            try
            {
                ArrayCalculation(arrayNumbers);
            }
            catch (IndexOutOfRangeException e)
            { 

                Console.WriteLine("Error" + e.Message);
            }
           
        
        }
        
        public static void ArrayCalculation(int [] arrayNumbers)
        {
            int sum = 0;
           
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write($"Introduce the element{i}: ");
                arrayNumbers[i] = int.Parse(Console.ReadLine() ?? "0");
                sum += arrayNumbers[i];
            }

            double average = (double)sum / arrayNumbers.Length;
            Console.WriteLine("This is the average of your elements: " + average);

        }
       
        //private int[] bunchOfNumbers;
    }
}
