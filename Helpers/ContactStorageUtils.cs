using Microsoft.VisualBasic.FileIO;
using Neckington.Interfaces;
using Neckington.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Neckington.Helpers
{
    public class ContactStorageUtils()
    {


        public static void SaveContact(Contact contact)
        {
            try
            {
                ProcessContactUtils.FileCreation(contact);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
        }
           
        public static void ShowContactOnScreen()
        {
            try
            {
            ProcessContactUtils.GetContact();
            }
            catch (Exception) 
            {
                Console.WriteLine("Contact can't be display");
            }

        }
        public static void DeleteContactMessage()
        {
            try
            {
                ProcessContactUtils.DeleteContact();
            }
            catch (Exception ex) 
            {

                Console.WriteLine("Contact can't be deleted" + ex.Message);
            }
           
        }

        public static void ContactExist() {

            Console.Clear();
            if (File.Exists(Constants.CreatePath))
            {
                Console.WriteLine("Contact exist!"); ;

            }
           else 
           {
                Console.WriteLine("Contact doesn't exist"); 
           }
                

        }
    
    }
}








