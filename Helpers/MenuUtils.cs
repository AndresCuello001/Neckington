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
       
        public static void InitializeLeapYear()
        {
            
            int dialogResult = LeapYearUtils.LeapYearDialog();
            LeapYearUtils.GetLeapYearResult(dialogResult);                        
        }

        public static void InitializeAverageCalculator()
        {

            int[] dialogAverageResult = AverageCalculatorUtils.AverageDialog();
            AverageCalculatorUtils.GetAverageCalculation(dialogAverageResult);

        }

        public static void InitializeNumberOrganizer()
        {

            int[] dialogArrayResult= NumOrganizerUtils.NumOrganizerMethod();
            NumOrganizerUtils.GetNumberOrganize(dialogArrayResult);

        }
        public static void InitiliazeGenderGuessser()
        {
            int dialogGenderGuesserResult= GenderGuesserUtils.GenderGuesserDialog();
            GenderGuesserUtils.GetGenderGuesserResult(dialogGenderGuesserResult);

        }


        public static void InitializeContactStorage()
        {
            
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("\n1. Register a contact");
            Console.WriteLine("\n2. Show contact");
            Console.WriteLine("\n3. Eliminate a contact");
            Console.WriteLine("--------------------");
            int option = int.Parse(Console.ReadLine());

            // bool ejecutando = true;
            
                //while(ejecutando)  
            
                switch (option)
                {

                    case 1:
                    Contact contact = new Contact();
                    Contact contactResult = contact.GetContact();
                        
                    break;
                           
                    case 2:
                    ContactStorageUtils.ShowContact();
                    break;

                    case 3:
                    ContactStorageUtils.DeleteContact();
                    break;
                }
               
            }

        
          
            
        
        
        
    }
    
    
}


