using Microsoft.VisualBasic.FileIO;
using Neckington.Interfaces;
using Neckington.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Neckington.Helpers
{
    public class ContactStorageUtils()
    {


        public static void Savecontact(Contact contact)
        {

            try
            {
                string path = @"C:\ArchivoC#\Contact.txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                    TextWriter tw = new StreamWriter(path);
                    tw.WriteLine(@$"Contact: FirstName: {contact.FirstName} LastName: {contact.LastName} Age: {contact.Age} Number: {contact.Number}");
                    tw.Close();
                }

                else if (File.Exists(path))
                {
                    using (var sw = new StreamWriter(path, true))

                        sw.WriteLine($"Contact: FirstName: {contact.FirstName} LastName: {contact.LastName} Age: {contact.Age} Number: {contact.Number}");
                
                    
                }
            }
            catch (Exception ex)
            {   
                Console.WriteLine("Error: " + ex.Message);
            
            }
        }
             
          public static void ShowContact()
          {
            Console.Clear();
            string path = @"C:\ArchivoC#\Contact.txt";

            if (File.Exists(path))
            {

                string contents = File.ReadAllText(@"C:\ArchivoC#\Contact.txt");
                Console.WriteLine(contents);

            }
            else {

                Console.WriteLine("Contact can't be read");
            
            }



          }
                public static void DeleteContact()
                {

                     string archivePath = @"C:\ArchivoC#\Contact.txt";

                    if (File.Exists(archivePath))
                    {
                        File.Delete(archivePath);
                        Console.WriteLine("Contact deleted!");
                    }
                    else
                    {

                        Console.WriteLine("Contact can't be deleted");
                    }
                }
     
        //private bool ejecutando = true;
    
    }
}








