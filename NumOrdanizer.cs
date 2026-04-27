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
        public static int[] NumOrganizerMethod()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your ordanizer number.... you're limited to 10 numbers ");
            Console.WriteLine("Please enter numbers that you want organize: ");
            string n = Console.ReadLine() ?? "0";
            int numberOfArrays = int.Parse(n);

            int[] arrayOrganizer = new int[numberOfArrays];

            return arrayOrganizer;
        }


        public static void NumOrganizerServiceMethod(int[] ParamArrayOrganizer)

        {
            int Numbers = 10;
            try
            {
                for (int i = 0; i <= Numbers; i++)
                {
                    Console.Write($"Introduce the element{i}: ");
                    ParamArrayOrganizer[i] = int.Parse(Console.ReadLine() ?? "0");

                    Console.WriteLine(ParamArrayOrganizer);
                }
                Console.WriteLine(ParamArrayOrganizer);

                Console.WriteLine("Array line : " + string.Join(",", ParamArrayOrganizer));

            }catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("Error" + e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine("Error" + e.Message);
            }
        }
 
    }
}
    // private int Numbers = 10;
     


