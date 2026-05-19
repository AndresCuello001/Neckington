using Microsoft.VisualBasic.FileIO;
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

namespace Neckington.Helpers
{
    public class ContactStorageUtils()
    {
        public static void FileContactCreation(Contact contact)
        {
            try
            {
                ProcessContactUtils.FileCreation(contact);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void ShowContactOnScreen()
        {
            try
            {
                 ProcessContactUtils.ShowFile();
            }
            catch (Exception) 
            {
                Console.WriteLine("Contact can't be display");
            }
        }
        
        public static void DeleteContact()
        {
            try
            {
                ProcessContactUtils.DeleteFile();
            }
            catch (Exception ex) 
            {

                Console.WriteLine("Contact has been deleted! " + ex.Message);
            }
           
        }

        public static void DoesContactExist()
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

        public static void SaveContact() 
        {
            List<string> contactStorage = new List<string>();

            try
            {
                if (File.Exists(Constants.ArchivePath))
                {
                    contactStorage = File.ReadAllLines(Constants.ArchivePath).ToList();
                }   
            }
            catch(Exception ex) {

               throw new ArgumentException(ex.Message);
            }     
        
        }
    }
}








