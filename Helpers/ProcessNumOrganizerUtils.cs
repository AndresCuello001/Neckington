using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Helpers
{
    public class ProcessNumOrganizerUtils
    {
        public static void GetNumbers(int[] ParamArrayOrganizer, int i)
        {

            Console.Write($"Introduce the element{i}: ");
            ParamArrayOrganizer[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        public static void ShowNumbers(int[] ParamArrayOrganizer)
        {

            Array.Sort(ParamArrayOrganizer);
            Console.WriteLine("Your numbers: " + string.Join(", ", ParamArrayOrganizer));
        }
    }
}
