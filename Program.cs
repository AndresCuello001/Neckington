using Neckington.Helpers;
using Neckington.Interfaces;
using System.Collections;
using System.ComponentModel.Design;

namespace Neckington
{
    public class Program
    {

        static void Main(string[] args)
        {
           
            try
            {
                MenuUtils menuUtils1 = new MenuUtils();
                int menuUtilityValue = MenuUtils.MenuDialog();
                MenuUtils.OptionMethod(menuUtilityValue);
            }
            catch (Exception ex) {

                Console.WriteLine("Error: " + ex.Message);
            
            }

            Console.WriteLine("Program continue here!");
         }
    }
}