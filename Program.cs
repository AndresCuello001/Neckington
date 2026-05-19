using Neckington.Interfaces;
using Neckington.src.Core.Helpers;
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
                Menu.ShowProgramName();
                Menu.ShowMenu();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}