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
    public static class MenuUtils
    {
        public static void ShowMenu() {

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
            
           OptionResult(NumberSelection);
       
        }
       
        public static void OptionResult(int NumberSelection)
        {

            try
            {
                switch (NumberSelection)
                {
                    case 1:
                        InitializeContactStorage();
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

                   GetOptionResult(option, ejecutando);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }
       
        public static void GetOptionResult(int option, bool ejecutando)
        {
            switch (option)
            {
                case 1:
                    Contact contact = new Contact();
                    Contact contactResult = contact.ContactCreation();
                    ContactStorageUtils.FileContactCreation(contactResult);
                    break;
                case 2:
                    ContactStorageUtils.ShowContactOnScreen();
                    break;
                case 3:
                    ContactStorageUtils.DoesContactExist();
                    break;
                case 4:
                    ContactStorageUtils.DeleteContact();
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

        public static void ShowProgramName() {
           
            Console.WriteLine("<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>");
            Console.WriteLine("..........NECKINGTON...........");
            Console.WriteLine("<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>");
            Thread.Sleep(5000);

        }
    
    
    }
}
            
        
        
        

    
    



