
using System.Collections;
using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using Neckington.Core;
using Neckington.Data;
using Neckington.Helpers;
namespace Neckington
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LogoHelper.ShowProgramName();
                Menu.ShowMenu();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}