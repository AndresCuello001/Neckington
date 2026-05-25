using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Neckington.Core.Base;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Neckington.Core.Configuration;
using Neckington.Helpers;

namespace Neckington.Core
{
    public class NumberHandler : BaseAction
    {
        
        public override void GetData(string DataProcessed)
        {
            
            int numberOfArrays = InputHelper.ReadInt(DataProcessed);
            
            var listOfArrays = new List<int>(numberOfArrays);
             ResultOrganize(listOfArrays, numberOfArrays);
        }
        public static string ProcessData()
        {
            Console.Clear();
            string n = InputHelper.ReadRequiredString(Constants.NumOrganizerMenu);

            return n;
        }
        public static void GetNumbers(List<int> listOfNumbers, int numberOfList)
        {
            int element = 0;

            for (int i = 0; i < numberOfList; i++)
            {
                element = InputHelper.ReadInt("Introduce the element: ");

                listOfNumbers.Add(element);
            }
            ShowNumbers(listOfNumbers);
        }

        public static void ShowNumbers(List<int> listOfNumbers)
        {
            listOfNumbers.Sort();
            Console.WriteLine("Your numbers: " + string.Join(", ", listOfNumbers));
        }
    
        public static void ResultOrganize(List<int> listOfNumbers, int numberOfList) => GetNumbers(listOfNumbers, numberOfList);

    } 
}   
     


