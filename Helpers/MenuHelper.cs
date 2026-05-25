using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Neckington.Models;
using Neckington.Core.Configuration;
using Neckington.Core.Base;
using System.Diagnostics;


namespace Neckington.Helpers
{
    public class MenuHelper
    {  
        public static int ProcessMenu() 
        {
            Console.Clear();
            Console.WriteLine(Constants.Menu);
            string selection = Console.ReadLine() ?? "0";
            int NumberSelection = int.Parse(selection);

            return NumberSelection;
        }
    }
}


            
        
        
        

    
    



