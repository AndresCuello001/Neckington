using Neckington.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Core.Configuration;
using System.IO.Compression;

namespace Neckington.Core.Base
{
    public class BaseRegistry
    {
        public void Create(dynamic entity)
        {
            using (var sw = new StreamWriter(Constants.ArchivePath, true))
            {
                sw.WriteLine(entity.ToString());
            }
        }

        public void Read()
        {
            if (File.Exists(Constants.ArchivePath))
            {
                var archive1 = File.ReadAllText(Constants.ArchivePath);
                Console.WriteLine(archive1);
            }
            else
            {
                Console.WriteLine("Contact does not exist!");
            }
        }

        public void Update()
        {
            if (File.Exists(Constants.ArchivePath))
            {
                string[] archive = File.ReadAllLines(Constants.ArchivePath);

                if (archive.Length > 0)
                {
                    archive[0] = "Line Updated";
                }
                File.WriteAllLines(Constants.ArchivePath, archive);
            }

        }

        public void Delete()
        {
            Console.Clear();
            if (File.Exists(Constants.ArchivePath)) 
            {
                File.Delete(Constants.ArchivePath);
                Console.WriteLine("Contact deleted!");
            }

            
        }
    }
}
       
    
    

      