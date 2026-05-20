using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Neckington.Models;
using Neckington.Utilities;
using Neckington.Core.Configuration;
using Neckington.Core.Base;
using System.Diagnostics;

namespace Neckington.Core.Helpers
{
    public class MenuHelper: ActionHelper
    {  
        public static int ProcessMenu() 
        {
            Console.Clear();
            Console.WriteLine(Constants.Menu);
            string selection = Console.ReadLine() ?? "0";
            int NumberSelection = int.Parse(selection);

            return NumberSelection;
        }
        
        
        public override void ExecuteOption(int NumberSelection)
        {
            try
            {
                switch (NumberSelection)
                {
                    case 1:
                        ContactManagment.InitializeContactStorage();
                        break;
                    case 2:
                        LeapYearUtils.InitializeLeapYear();
                        break;
                    case 3:
                        AverageCalculator.InitializeAverageCalculator();
                        break;
                    case 4:
                        NumOrganizerHelper.InitializeNumberOrganizer();
                        break;
                    case 5:
                        GenderGuesserUtils.InitiliazeGenderGuessser();
                        break;

                    default:
                        throw new ArgumentException("The selection number doesn't exist");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error" + ex.Message);
            }

        }

    }
}
            
        
        
        

    
    



