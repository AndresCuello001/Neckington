using Microsoft.VisualBasic.FileIO;
using Neckington.Configuration;
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

        public static void InitializeContactStorage()
        {
            bool ejecutando = true;


            try
            {
                while (ejecutando)
                {

                    Console.Clear();
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("\n1. Register a contact");
                    Console.WriteLine("\n2. Show contact");
                    Console.WriteLine("\n3. Does contact exist?");
                    Console.WriteLine("\n4. Eliminate a contact");
                    Console.WriteLine("--------------------");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Contact contact = new Contact();
                            Contact contactResult = contact.ContactCreation();
                            ContactStorageUtils.SaveContact(contactResult);
                            break;
                        case 2:
                            ContactStorageUtils.ShowContactOnScreen();
                            break;
                        case 3:
                            ContactStorageUtils.ContactExist();
                            break;
                        case 4:
                            ContactStorageUtils.DeleteContactMessage();
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
            catch (Exception ex) {
                Console.WriteLine("Error" + ex.Message);
            }
        
        
        }

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
            if (File.Exists(Constants.ArchivePath))
            {
                Console.WriteLine("Contact exist!");
            }
           else 
           {
                Console.WriteLine("Contact doesn't exist"); 
           }
                

        }
    
    }
}








