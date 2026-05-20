using Neckington.Core.Configuration;
using Neckington.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Core.Base
{
    public class GenderGuesserUtils: M
    
        public static void InitiliazeGenderGuessser()
        {
            GenderGuesserUtils genderGuesserObject = new GenderGuesserUtils();
            genderGuesserObject.ProcessData();
            
        }
        public override void ProcessData()
        {
            Console.WriteLine(Constants.GenderGuesserMenu);
            string enter1 = Console.ReadLine() ?? "0";
            int enterValue = int.Parse(enter1); 
            
            GetResult(enterValue);
        }

        public static void GetResult(int value)
        { 
            if (value <= 10)
            {
                Console.WriteLine(" You're a Men"); 
            }
            else
            {
                Console.WriteLine("You're a Women");
            }
        }
    }
}