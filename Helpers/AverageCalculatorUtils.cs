using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Helpers
 {
   public class AverageCalculatorUtils
    {

        public static void InitializeAverageCalculator()
        {

            int[] dialogAverageResult = AverageCalculatorUtils.AverageDialog();
            AverageCalculatorUtils.GetAverageCalculation(dialogAverageResult);

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

        public static void GetAverageCalculation(int[] arrayNumbers){  
            
            int sum = 0;
            try
            {
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    Console.Write($"Introduce the element{i}: ");
                    arrayNumbers[i] = int.Parse(Console.ReadLine() ?? "0");
                    sum += arrayNumbers[i];
                }
                
                double average = (double)sum / arrayNumbers.Length;
                Console.WriteLine("This is the average of your elements: " + average);
            }
            catch (IndexOutOfRangeException e)
            { 

                Console.WriteLine("Error" + e.Message);
            }
            

        }

       
        //private int[] bunchOfNumbers;
    }
}
