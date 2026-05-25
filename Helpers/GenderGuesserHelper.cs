using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Core.Configuration;
using Neckington.Core.Base;
namespace Neckington.Helpers
{
       public class GenderGuesserHelper: BaseAction
       {
            public static int ProcessData()
            {
                Console.Clear();
                Console.WriteLine(Constants.GenderGuesserMenu);
               
                string enter1 = Console.ReadLine() ?? "0";
                
                int enterValue = int.Parse(enter1);
                
                return enterValue;
            }
        }
}
