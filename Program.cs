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
                MenuUtils.ShowProgramName();
                MenuUtils.ShowMenu();
            }
            catch (Exception ex) {

                Console.WriteLine("Error: " + ex.Message);
            }
           
        }
    }
}