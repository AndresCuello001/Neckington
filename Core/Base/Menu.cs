using Neckington.Core.Configuration;
using Neckington.Core.Helpers;
using Neckington.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Neckington.Core.Base
{
    public class Menu : ActionHelper
    {
        public static void ShowProgramName()
            {

            Console.WriteLine("<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>");
            Console.WriteLine("..........NECKINGTON...........");
            Console.WriteLine("<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>");
            Thread.Sleep(5000);

        }

        public static void ShowMenu()
        {
            int NumberSelection = MenuHelper.ProcessMenu();

            MenuHelper menuUtilsObject = new MenuHelper();
            menuUtilsObject.ExecuteOption(NumberSelection);
        }

        public override void ExecuteOption(int option, bool ejecutando)
        {
            switch (option)
            {
                case 1:
                    Contact contact = new Contact();
                    Contact contactResult = contact.ContactCreation();
                    ContactManagment.FileContactCreation(contactResult);
                    break;
                case 2:
                    ContactManagment.ShowContactOnScreen();
                    break;
                case 3:
                    ContactManagment.DoesContactExist();
                    break;
                case 4:
                    ContactManagment.DeleteContact();
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
    }
}
