using Microsoft.VisualBasic.FileIO;
using Neckington.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Neckington.Helpers
{
    public class MenuUtils
    {
        public static int MenuDialog() {

            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Welcome to Neckington");
            Console.WriteLine("What options are you looking for?");
            Console.WriteLine("1. Storage Contacts");
            Console.WriteLine("2. Calculate Leap-Year ");
            Console.WriteLine("3. PromCalculaor ");
            Console.WriteLine("4. Number Organizer");
            Console.WriteLine("5. GenderGuesser");
    
            Console.WriteLine("--------------------------------------");
            string selection = Console.ReadLine() ?? "0";
            int NumberSelection = int.Parse(selection);
            
            return NumberSelection;
        }
       
        public static void OptionMethod(int NumberSelection)
        {

            try
            {
                switch (NumberSelection)
                {
                    case 1:
                        ContactStorageUtils.InitializeContactStorage();
                        break;
                    case 2:
                        LeapYearUtils.InitializeLeapYear();
                        break;
                    case 3:
                        AverageCalculatorUtils.InitializeAverageCalculator();
                        break;
                    case 4:
                        NumOrganizerUtils.InitializeNumberOrganizer();
                        break;
                    case 5:
                        GenderGuesserUtils.InitiliazeGenderGuessser();
                        break;

                    default:
                        throw new ArgumentException("The selection number doesn't exist");
                }
            }
            catch (Exception ex) {

                Console.WriteLine("Error" + ex.Message);
            }
               
         }

    }

}
            
        
        
        

    
    



