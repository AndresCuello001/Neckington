using Microsoft.VisualBasic.FileIO;
using Neckington.Core.Base;
using Neckington.Core.Configuration;
using Neckington.Models;
using Neckington.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Neckington.Core.Helpers
{
    public class ContactManagmentHelper()
    {
        public static void FileCreation(Contact contact)
        {
            Console.Clear();
            using (var sw = new StreamWriter(Constants.ArchivePath, true))
            {
                sw.WriteLine($"Contact: {contact.Id} FirstName: {contact.FirstName} LastName: {contact.LastName} Age: {contact.Age} Number: {contact.PhoneNumber} WorkNumber: {contact.WorkNumber} Address: {contact.Address}");
            }
            ContactManagment.SaveContact();
        }

        public static void ShowFile()
        {
            Console.Clear();
            string contents = File.ReadAllText(Constants.ArchivePath);
            Console.WriteLine(contents);

        }

        public static void DeleteFile()
        {

            Console.Clear();
            if (File.Exists(Constants.ArchivePath))

                File.Delete(Constants.ArchivePath);
            Console.WriteLine("Contact deleted!");
        }

        public static void ContactProve()
        {
            Console.Clear();
            if (File.Exists(Constants.ArchivePath))
            {
                Console.WriteLine("Contact exist!");
            }
            else
            {
                Console.WriteLine("Contact doesn't exist");
            }

        }


        public static void ProcessContact()
        {
            List<string> contactStorage = new List<string>();

            try
            {
                if (File.Exists(Constants.ArchivePath))
                {
                    contactStorage = File.ReadAllLines(Constants.ArchivePath).ToList();
                }
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }
       
    }
} 








