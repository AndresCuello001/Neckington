using Neckington.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Helpers
{
    public static class InputHelper
    {
       public static int ReadInt(string message)
       {
         int result;

            while (true)
            {
                Console.Write($"{message}: ");

                string? input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    return result;
                }
                else 
                {    
                    Console.WriteLine("Invalid number. Try again.");
                }
            }
       }

        public static long ReadLong(string message)
        {
            long result;

            while (true)
            {
                Console.Write($"{message}: ");

                string? input = Console.ReadLine();

                if (long.TryParse(input, out result))
                {
                    return result;
                }

                Console.WriteLine("Invalid number. Try again.");
            }
        }

        public static string ReadRequiredString(string message)
        {
            while (true)
            {
                Console.Write($"{message}: ");

                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }

                Console.WriteLine("This field is required.");
            }
        }

        public static string ReadOptionalString(string message)
        {
            Console.Write($"{message}: ");

            return Console.ReadLine() ?? string.Empty;
        }
          
        public static DateTime ReadRequiredDateTime(string message)
        {
           Console.Write(message);

           string input = Console.ReadLine();

           if (DateTime.TryParse(input, out DateTime dob))
           {
             return dob;
           }
            Console.WriteLine("Invalid date");
             return DateTime.MinValue;
        }
    }
}
 


