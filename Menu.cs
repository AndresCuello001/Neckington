using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Neckington
{
    public class Menu
    {
        public void StartProgram()
        {
            
                Console.Clear();
                Console.WriteLine("Welcome to Neckington");
                Console.WriteLine("What options are you looking for?");
                Console.WriteLine("1. Storage Contacts");
                Console.WriteLine("2. Calculate Leap-Year ");
                Console.WriteLine("3. PromCalculaor ");
                Console.WriteLine("4. Number Ordanizer");
                Console.WriteLine("5. GenderGuesser");

                string selection = (Console.ReadLine() ?? "0");

                int NumberSelection = int.Parse(selection);


                switch (NumberSelection)
                {
                    case 1:
                        ContactStorage.ContactDialogMethod();
                        break;

                    case 2:
                        LeapYear.DialogLeapYearCalculation();
                        break;

                    case 3:
                        AverageCalculator.PromForm();
                        break;
                    case 4:
                     NumOrganizer.NumOrganizerMethod();
                        break;
                    case 5: 
                    
                
                 default:
                        break;
                }
        }

            
        
        private bool Ejecutando = true;
    }
}




