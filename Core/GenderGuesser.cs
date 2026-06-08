using Neckington.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Core.Base;
using Neckington.Helpers;
namespace Neckington.Core
{
    public class GenderGuesser: BaseAction
    { 
      public static void InitiliazeGenderGuessser()
      {
          GenderGuesser genderGuesserObject = new GenderGuesser();
          genderGuesserObject.GetData();
      }
        
     public void GetData()
     {
            int enterValue = ProcessData();
            GetResult(enterValue);
    }

        public static int ProcessData()
        {
            Console.Clear();
            string enter1 = InputHelper.ReadOptionalString(Constants.GenderGuesserMenu);
            int enterValue = int.Parse(enter1);

            return enterValue;
        }
        public static void GetResult(int value) => Console.WriteLine(value <= 10 ? "You're a Men" : "You're a Women");
    } 
}