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
using Neckington.Helpers;

namespace Neckington.Core
{
    public class NumOrganizer : BaseAction
    {
        public static void InitializeNumberOrganizer()
        {
            //GetData();
        }

        public override void GetData()
        {
           string DataProcessed = NumOrganizerHelper.ProcessData();

            int numberOfArrays = int.Parse(DataProcessed);

            var listOfArrays = new List<int>(numberOfArrays);
    
            ResultOrganize(listOfArrays, numberOfArrays);
        }

        public static void ResultOrganize(List<int> listOfNumbers, int numberOfList) => NumOrganizerHelper.GetNumbers(listOfNumbers, numberOfList);

    } 
}   
     


