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
            Console.Clear();
            TextWriter archiveFile =new StreamWriter("C:\\Users\\Andre\\OneDrive\\Escritorio\\RutaArchivoC#\\Contact.txt");
            string contactFile = $"Contact: FirstName: {contact.FirstName} LastName: {contact.LastName} Age: {contact.Age} Number: {contact.Number}";
            archiveFile.WriteLine(contactFile);
            archiveFile.Close();
        
        }

        public static void ShowContact()
        {
            Console.Clear();
            string archivePath = "C:\\Users\\Andre\\OneDrive\\Escritorio\\RutaArchivo\\Contact.txt";

            if (!File.Exists(archivePath))
            {
                using (StreamReader contactReader = new StreamReader(archivePath))
                {
                    string contactFile = contactReader.ReadToEnd();
                    Console.WriteLine(contactFile);
                }
            }
            else
            {
                Console.WriteLine("Contact not saved!");
            }
        }

        public static void DeleteContact()
        {

            string archivePath = @"C:\\Users\\Andre\\OneDrive\\Escritorio\\Contact.txt";

            if (File.Exists(archivePath))
                {
                File.Delete(archivePath);
                Console.WriteLine("Archive deleted!");
            }
            else
            {

                Console.WriteLine("Archive can't be deleted");
            }
        }
    }
    }








