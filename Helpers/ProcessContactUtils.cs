using Neckington.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Helpers
{
    public class ProcessContactUtils
    {
        public static void FileCreation(Contact contact) 
        {
            Console.Clear();
            using (var sw = new StreamWriter(Constants.CreatePath, true))
            sw.WriteLine($"Contact: FirstName: {contact.FirstName} LastName: {contact.LastName} Age: {contact.Age} Number: {contact.Number}");

            
        }

        public static void GetContact() {

           Console.Clear();
           string contents = File.ReadAllText(Constants.ShowPath);
           Console.WriteLine(contents);

            
        }

        public static void DeleteContact() {
           
            Console.Clear();
            if (File.Exists(Constants.DeletePath))
            
                File.Delete(Constants.DeletePath);
                Console.WriteLine("Contact deleted!");

        }



    }
    
}


    
    
    
