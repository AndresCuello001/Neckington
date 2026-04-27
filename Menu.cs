using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Neckington
{
    public class Menu
    {
        public static void ProgramInit()
        {
           int menuUtilityValue = MenuUtils.MenuDialog();
            MenuUtils.SwitchCaseMenu(menuUtilityValue);
        }
    }
}




