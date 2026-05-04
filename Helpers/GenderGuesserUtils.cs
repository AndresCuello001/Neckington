using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Helpers
{
    public class GenderGuesserUtils
    {
        public static void InitiliazeGenderGuessser()
        {
            int dialogGenderGuesserResult = GenderGuesserUtils.GenderGuesserDialog();
            GenderGuesserUtils.GetGenderGuesserResult(dialogGenderGuesserResult);

        }

        public static int GenderGuesserDialog()
        {
            Console.Clear();
            Console.WriteLine("You have selected the Gender guesser");
            Console.WriteLine("Next you have to answer these follow questions to guess your gender");

            Console.WriteLine("If you're a men type whatever number between 1 and 10 ");
            string enter1 = Console.ReadLine() ?? "0";

            int enterValue = int.Parse(enter1); 
            
            return enterValue;
            // I return value when i want to storage in a value
        }


        public static void  GetGenderGuesserResult(int value)
        {  
            
            if (value <= 10)
            {
                Console.WriteLine(" You're a Men"); 
            }
            else
            {
                Console.WriteLine("You're a Women");
            }


        }
    }



}