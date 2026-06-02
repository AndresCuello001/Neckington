using Neckington.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Services
{
   public class NumberHandlerServices
   {
        public static void InitializeNumberHandler()
        {
            string DataProcessed = NumberHandler.ProcessData();
            NumberHandler numberHandlerObject = new NumberHandler();
            numberHandlerObject.GetData(DataProcessed);
        }
   }
}
