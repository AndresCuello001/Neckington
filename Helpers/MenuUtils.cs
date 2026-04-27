using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Helpers
{
    public class MenuUtils
    {
        public static int MenuDialog() {

            Console.Clear();
            Console.WriteLine("Welcome to Neckington");
            Console.WriteLine("What options are you looking for?");
            Console.WriteLine("1. Storage Contacts");
            Console.WriteLine("2. Calculate Leap-Year ");
            Console.WriteLine("3. PromCalculaor ");
            Console.WriteLine("4. Number Ordanizer");
            Console.WriteLine("5. GenderGuesser");
            string selection = Console.ReadLine() ?? "0";
            int NumberSelection = int.Parse(selection);
            
            return NumberSelection;
        }


        public static void OptionMethod(int NumberSelection ) {

            switch (NumberSelection)
            {
                case 1:
                    ContactStorageUtils.ContactDialog();
                break;
                case 2:
                    LeapYearUtils.LeapYearDialog();
                break;
                case 3:
                    int[] resultAverageDialog = AverageCalculatorUtils.AverageDialog();
                    AverageCalculatorUtils.AverageCalculateMethod(resultAverageDialog);
                break;
                case 4:
                    int[] resultArrayDialog = NumOrganizerUtils.NumOrganizerMethod();
                    NumOrganizerUtils.NumOrganizerServiceMethod(resultArrayDialog);
                break;
                case 5:
                     int resultGenderGuesserDialog = GenderGuesserUtils.GenderGuesserDialogMethod();
                      GenderGuesserUtils.GenderGuesserMethod(resultGenderGuesserDialog);
                break;

                default:
                    break;
            }
        }
    }
}
