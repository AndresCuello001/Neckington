using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington
{
    public class NumOrganizer

    {

        public NumOrganizer(int ParamNumbers)
        {
       
        }

        public static void NumOrganizerMethod() { 
            Console.Clear();
            Console.WriteLine("Welcome to your ordanizer number.... you're limited to 5 numbers ");
            Console.WriteLine("Please enter numbers that you want organize: ");
            string n = Console.ReadLine() ?? "0";
            int numberOfArrays = int.Parse(n);

            int[] arrayOrganizer = new int[numberOfArrays];

            //const int Numbers = 5;

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Introduce the element{i}: ");
                    arrayOrganizer[i] = int.Parse(Console.ReadLine() ?? "0");

                    Array.Sort(arrayOrganizer);
                }
               
            }
            catch (Exception) {

                Console.WriteLine("Error");
            }





        }

        private int Numbers; 
    }
}
