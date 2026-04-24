using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Neckington
    {
   public class PromCalculator
    {

        public PromCalculator(int[] ParamBunchOfNumbers) 
        {
            bunchOfNumbers = ParamBunchOfNumbers;  
        }

        public static void PromForm() {

            Console.Clear();
            Console.WriteLine("You have select the PromCalculator: ");

            Console.WriteLine("Write down How many numbers you wanna calculate: ");
            string n = Console.ReadLine() ?? "0";
            int numberOfArrays = int.Parse(n);

            int[] arrayNumbers = new int[numberOfArrays];

            try
            {
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    Console.Write($"Introduce the element{i}: ");
                    arrayNumbers[i] = int.Parse(Console.ReadLine() ?? "0");
                }

            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Error");
            }
            

        }


        private int[] bunchOfNumbers;
    }
}
