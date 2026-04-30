using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Models;


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
            Console.WriteLine("4. Number Organizer");
            Console.WriteLine("5. GenderGuesser");
            string selection = Console.ReadLine() ?? "0";
            int NumberSelection = int.Parse(selection);
            
            return NumberSelection;
        }
        public static void OptionMethod(int NumberSelection)
        {

            switch (NumberSelection)
            {
                case 1:
                    Case1Method();
                    break;
                case 2:
                    Case2Method();
                    break;
                case 3:
                    Case3Method();
                    break;
                case 4:
                    Case4Method();
                    break;
                case 5:
                    Case5Method();
                    break;

                default:
                    throw new ArgumentException("The selection Number Doesn't exist");
            }
        }
        public static void Case1Method()
        {
            ContactStorageUtils contactStorage = new ContactStorageUtils();
            var contactResult = contactStorage.ContactDialog();
            contactStorage.ContactStorageMethod(contactResult);

        }
        public static void Case2Method()
        {
            int leapYearResult = LeapYearUtils.LeapYearDialog();
            LeapYearUtils.LeapYearResult(leapYearResult);                        
        }

        public static void Case3Method()
        {

            int[] resultAverageDialog = AverageCalculatorUtils.AverageDialog();
            AverageCalculatorUtils.AverageCalculateMethod(resultAverageDialog);

        }

        public static void Case4Method()
        {

            int[] resultArrayDialog = NumOrganizerUtils.NumOrganizerMethod();
            NumOrganizerUtils.NumOrganizerServiceMethod(resultArrayDialog);

        }
        public static void Case5Method()
        {
            int resultGenderGuesserDialog = GenderGuesserUtils.GenderGuesserDialogMethod();
            GenderGuesserUtils.GenderGuesserMethod(resultGenderGuesserDialog);

        }
    }
}

