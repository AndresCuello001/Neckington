using Neckington.Core;
using Neckington.Core.Configuration;
using Neckington.Helpers;
using Neckington.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Services;


namespace Neckington.View.ConsoleUI
{
   public class ConsoleUI
   {
        public static int ProcessMenu()
        {
            Console.Clear();
            string selection = InputHelper.ReadRequiredString(Constants.Menu);
            int OptionSelection = InputHelper.ReadInt(selection);

            return OptionSelection;
        }

        public static void ShowMenu()
        {
            Console.Clear();
            int NumberSelection = ProcessMenu();
            ExecuteOption(NumberSelection);
        }

        public static void ExecuteOption(int NumberSelection)
        {
            try
            {
                switch (NumberSelection)
                {
                    case 1:
                        InitializeContactStorage();
                        break;
                    case 2:
                       LeapYearServices.InitializeLeapYear();
                        break;
                    case 3:
                        AverageCalculatorServices.InitializeAverageCalculator();
                        break;
                    case 4:
                        NumberHandlerServices.InitializeNumberHandler();
                        break;
                    case 5:
                        GenderGuesserServices.InitiliazeGenderGuessser();
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

        public static void InitializeContactStorage()
        {
            try
            {
                ExecuteContactMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void ExecuteContactMenu()
        {
            int option = InputHelper.ReadInt(Constants.InitializeContactStorageMenu);
            ShowContactMenu(option);
        }

        public static void ShowContactMenu(int option)
        {
            Console.Clear();
            switch (option)
            {
                case 1:
                    ContactServices.CreateContact();
                    break;
                case 2:
                    ContactServices.ReadContact();
                    break;
                case 3:
                    ContactServices.UpdateContact();
                    break;
                case 4:
                    ContactServices.DeleteContact();
                    break;
                default:
                    throw new ArgumentException("Option doesn't exits");
            }
        }

        public Contact ContactCreation()
        {
            var contact = new Contact();

            Console.Clear();

            contact.FirstName = InputHelper.ReadRequiredString("Introduce the first name: ");

            contact.LastName = InputHelper.ReadRequiredString("Introduce the last name: ");

            contact.DateOfBirth = InputHelper.ReadRequiredDateTime("Introduce the Date Of birth: ");

            contact.UserEmail = InputHelper.ReadRequiredString("Introduce the Email: ");

            contact.PhoneNumber = InputHelper.ReadInt("Introduce number: ");

            contact.WorkNumber = InputHelper.ReadLong("Introduce WorkNumber: ");

            contact.Address = InputHelper.ReadRequiredString("Introduce the Address: ");

            return contact;
        }
   }
}
