using Neckington.Core.Configuration;
using Neckington.Core.Helpers;
using Neckington.Models;
using Neckington.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Neckington.Core.Base
{
    public class ContactManagment
    {
        public static void InitializeContactStorage()
        {
            bool ejecutando = true;
            try
            {
                while (ejecutando)
                {
                    Console.WriteLine(Constants.InitializeContactStorageMenu);
                    int option = int.Parse(Console.ReadLine());
                    
                    MenuHelper menuObject = new MenuHelper();
                    menuObject.ExecuteOption(option, ejecutando);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }
        public static void FileContactCreation(Contact contact) => ContactManagmentHelper.FileCreation(contact);

        public static void ShowContactOnScreen() => ContactManagmentHelper.ShowFile();

        public static void DeleteContact() => ContactManagmentHelper.DeleteFile();

        public static void DoesContactExist() => ContactManagmentHelper.ContactProve();

        public static void SaveContact() => ContactManagmentHelper.ProcessContact();
           
    }
}
