using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Helpers
{
    public class ProcessNumOrganizerUtils
    {
        public static void GetNumbers(List<int> listOfNumbers, int numberOfList)
        {
            int element = 0;
            
            for (int i = 0; i < numberOfList; i++)
            {

                Console.WriteLine("Introduce the element: ");
                element = Int32.Parse(Console.ReadLine());

                listOfNumbers.Add(element);

            }
            ShowNumbers(listOfNumbers);
        }
       
        public static void ShowNumbers(List<int> listOfNumbers)
        {
            listOfNumbers.Sort();
            Console.WriteLine("Your numbers: " + string.Join(", ", listOfNumbers));
        }
    }
}
