
using Neckington.Core.Helpers;
using System.Collections;
using System.ComponentModel.Design;
using Neckington.Core.Base;
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