using Neckington.Core.Configuration;
using Neckington.Helpers;
using Neckington.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Utilities
{
    public class ProcessContactUtils
    {
        public static void FileCreation(Contact contact) 
        {
            Console.Clear();
            using (var sw = new StreamWriter(Constants.ArchivePath, true)) 
            {
                sw.WriteLine($"Contact: {contact.Id} FirstName: {contact.FirstName} LastName: {contact.LastName} Age: {contact.Age} Number: {contact.PhoneNumber} WorkNumber: {contact.WorkNumber} Address: {contact.Address}");
            }
             ContactStorageUtils.SaveContact();
        }

        
        public static void ShowFile() 
        {
           Console.Clear();
           string contents = File.ReadAllText(Constants.ArchivePath);
           Console.WriteLine(contents);
    
        }


        public static void DeleteFile() {
           
            Console.Clear();
            if (File.Exists(Constants.ArchivePath))
            
            File.Delete(Constants.ArchivePath);
            Console.WriteLine("Contact deleted!");
        }

       
    }

}
    



    
    
    
