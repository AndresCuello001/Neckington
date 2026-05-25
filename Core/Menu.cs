using Neckington.Core.Base;
using Neckington.Core.Configuration;
using Neckington.Helpers;
using Neckington.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Neckington.Core
{
    public class Menu : BaseAction
    {
        public static void ShowProgramName()
        {
            Console.WriteLine("<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>");
            Console.WriteLine("..........NECKINGTON...........");
            Console.WriteLine("<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>");
            Thread.Sleep(5000);
        }
        public static int ProcessMenu()
        {
            Console.Clear();
            Console.WriteLine(Constants.Menu);
            string selection = Console.ReadLine() ?? "0";
            int NumberSelection = int.Parse(selection);

            return NumberSelection;
        }

        public static void ShowMenu()
        {
            int NumberSelection = MenuHelper.ProcessMenu();

            Menu menuUtilsObject = new Menu();
            menuUtilsObject.ExecuteOption(NumberSelection);
        }
        
        public override void ExecuteOption(int NumberSelection)
        {
            try
            {
                switch (NumberSelection)
                {
                    case 1:
                        InitializeContactStorage();
                        break;
                    case 2:
                           // LeapYear.();
                        break;
                    case 3:
                        InitializeAverageCalculator();
                        break;
                    case 4:
                        NumOrganizer.InitializeNumberOrganizer();
                        break;
                    case 5:
                        GenderGuesser.InitiliazeGenderGuessser();
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
            bool ejecutando = true;
            try
            {
                ContactManagment.ExecuteContactMenu(ejecutando);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }
        public static void InitializeAverageCalculator()
        {
            AverageCalculator average = new AverageCalculator();
            average.GetData();
        }
        public override void ExecuteOption(int option, bool ejecutando)
        {
            switch (option)
            {
                case 1:
                    CreateContact();
                    break;
                case 2:
                    ReadContact();
                    break;
                case 3:
                    UpdateContact();
                    break;
                case 4:
                    DeleteContact();
                    break;
                default:
                    throw new ArgumentException("Option doesn't exits");
            }
            if (ejecutando)
            {
                Console.WriteLine("\nPresiona una tecla para continuar");
                Console.ReadKey();
            }
        }
        public static void ExecuteContactMenu(bool ejecutando)
        {
            Console.Clear();
            Console.WriteLine(Constants.InitializeContactStorageMenu);
            int option = int.Parse(Console.ReadLine());

            ContactManagment contactManagmentObject = new ContactManagment();
            contactManagmentObject.ExecuteOption(option, ejecutando);



        public static void CreateContact()
        {

            Contact contactObject1 = new Contact();
            var contact = contactObject1.ContactCreation();
            contactObject1.Create(contact);
        }

        public static void ReadContact()
        {
            Contact Contactobject2 = new Contact();
            Contactobject2.ShowContact();

        }

        public static void UpdateContact()
        {
            Contact contactObject2 = new Contact();
            contactObject2.Update();
        }

        public static void DeleteContact()
        {
            Contact contactObject3 = new Contact();
            contactObject3.ContactDelete();

        }
        public static void InitializeAverageCalculator()
        {
            AverageCalculator average = new AverageCalculator();
            average.GetData();
        }

    }
}
