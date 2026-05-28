using Microsoft.Extensions.Options;
using Neckington.Core.Base;
using Neckington.Core.Configuration;
using Neckington.Data;
using Neckington.Data.Repositories;
using Neckington.Helpers;
using Neckington.Models;
using Neckington.Services;
using Spectre.Console;
namespace Neckington.Core
{
    public class Menu : BaseAction
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

            Menu menuObject = new Menu();
            menuObject.ExecuteOption(NumberSelection);
        }

        public override void ExecuteOption(int NumberSelection)
        {
            Console.Clear();
            bool ejecutando = true;
            while (ejecutando)
            {
                try
                {
                    switch (NumberSelection)
                    {
                        case 1:
                            InitializeContactStorage();
                            break;
                        case 2:
                            InitializeLeapYear();
                            break;
                        case 3:
                            InitializeAverageCalculator();
                            break;
                        case 4:
                            InitializeNumberOrganizer();
                            break;
                        case 5:
                            InitiliazeGenderGuessser();
                            break;

                        default:
                            throw new ArgumentException("The selection number doesn't exist");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);
                }
            
            if(ejecutando)
             Console.WriteLine("\nPresiona una tecla para continuar");
              Console.ReadKey();
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
        public static void InitializeAverageCalculator()
        {   
            AverageCalculator average = new AverageCalculator();
            average.ProcessingData();
        }

        public static void InitializeLeapYear() 
        {
            int year = LeapYear.ProcessData();
            LeapYear.GetResult(year);
        }

        public static void InitiliazeGenderGuessser()
        {
            GenderGuesser genderGuesserObject = new GenderGuesser();
            genderGuesserObject.GetData();
        }

        public static void InitializeNumberOrganizer()
        {
            string DataProcessed = NumberHandler.ProcessData();
            NumberHandler numberHandlerObject = new NumberHandler();
            numberHandlerObject.GetData(DataProcessed);
        }
        public static void ExecuteContactMenu()
        {
            int option = InputHelper.ReadInt(Constants.InitializeContactStorageMenu);

            Menu contactManagmentObject = new Menu();
            ExecuteContactMenu(option);
        }
        public static void ExecuteContactMenu(int option)
        {
            Console.Clear();    
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
         }
            
        public static void CreateContact()
        {
            Console.Clear();
            var options = DatabaseConfig.GetOptions();
            var context = new AppDbContext(options);

            ContactCreation(context);
        }

        public static void ContactCreation(AppDbContext context)
        {

            ContactRepository<Contact> contactRepositoryObject = new ContactRepository<Contact>(context);
            var contact = ContactServices.GetContactCreation();
            contactRepositoryObject.Create(contact);
        }

        public static void ReadContact()
        {
            //Contact Contactobject2 = new Contact();
           // Contactobject2.ShowContact();
        }

        public static void UpdateContact()
        {
            //Contact contactObject2 = new Contact();
           //contactObject2.Update();
        }

        public static void DeleteContact()
        {
            //Contact contactObject3 = new Contact();
            //contactObject3.ContactDelete();
        }
        public static Contact GetContactCreation()
        {
            ContactServices contactServicesObject = new ContactServices();
            var contact = contactServicesObject.ContactCreation();
            return contact;
        }
        
        public static void ShowProgramName()
        {
            
         string[] logo = new[]
            
         {
        "███╗   ██╗███████╗ ██████╗██╗  ██╗██╗███╗   ██╗ ██████╗ ████████╗ ██████╗ ███╗   ██╗",
        "████╗  ██║██╔════╝██╔════╝██║ ██╔╝██║████╗  ██║██╔════╝ ╚══██╔══╝██╔═══██╗████╗  ██║",
        "██╔██╗ ██║█████╗  ██║     █████╔╝ ██║██╔██╗ ██║██║  ███╗   ██║   ██║   ██║██╔██╗ ██║",
        "██║╚██╗██║██╔══╝  ██║     ██╔═██╗ ██║██║╚██╗██║██║   ██║   ██║   ██║   ██║██║╚██╗██║",
        "██║ ╚████║███████╗╚██████╗██║  ██╗██║██║ ╚████║╚██████╔╝   ██║   ╚██████╔╝██║ ╚████║",
        "╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝ ╚═════╝    ╚═╝    ╚═════╝ ╚═╝  ╚═══╝",
        };

            Console.Clear();
            int top = (Console.WindowHeight - logo.Length) / 2;

            foreach (var line in logo)
            {
                int left = (Console.WindowWidth - line.Length) / 2;
                Console.SetCursorPosition(Math.Max(0, left), top++);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(line);
            }

            Console.ResetColor();
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}

