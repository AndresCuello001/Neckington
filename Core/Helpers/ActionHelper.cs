using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Neckington.Core.Helpers
{
   public class ActionHelper
   {
        public virtual void ShowResult(int sum, int[] arraynumbers) => Console.WriteLine("Show Result");
        public virtual void ShowResult() => Console.WriteLine();
        public virtual void ExecuteOption(int numberSelection) => Console.WriteLine();
        public virtual void ExecuteOption(int option, bool ejecutando) => Console.WriteLine();
        public virtual void ProcessData() => Console.WriteLine("Here the data is Processed");
        

    }
}
