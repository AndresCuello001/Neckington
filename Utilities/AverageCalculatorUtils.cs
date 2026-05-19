using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Utilities
{
    public class AverageCalculatorUtils
    {
        public static void GetCalculation(int[] arrayNumbers)
        {
            int sum = 0;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write($"Introduce the element{i}: ");
                arrayNumbers[i] = int.Parse(Console.ReadLine() ?? "0");
                sum += arrayNumbers[i];
            }
            ShowResult(sum, arrayNumbers);
        }

        public static void ShowResult(int sum, int[] arrayNumbers)
        {
            double average = (double)sum / arrayNumbers.Length;
            Console.WriteLine("This is the average of your elements: " + average);
        }

    }
}
