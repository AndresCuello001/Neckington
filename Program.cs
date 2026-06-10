using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using Neckington.Core;
using Neckington.Data;
using Neckington.Data.Repositories;
using Neckington.Helpers;
using Neckington.Models;
using Neckington.Application.Services;
using Neckington.View.ConsoleUI;
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
                LogoHelper.ShowProgramName();
                var dbContext = new ContactDbContext();

                var repository = new ContactRepository<Contact>(dbContext);

                var service = new ContactServices(repository);

                var ui = new ConsoleUI(service);
                ui.ShowMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}