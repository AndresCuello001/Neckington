using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Core.Configuration
{
public static class Constants
{
public const string ArchivePath = @"C:\ArchivoC#\Contact.txt";

 public const string Menu = 
@"---------------------------------
Welcome to Neckington
What options are you looking for?
1. Manage Contacts
2. Calculate Leap-Year
3. Average Calculator
4. Number Handler
5. Gender Guesser
 ----------------------------------";

public const string AverageMenu =           
@"You have select the PromCalculator:            
Write down How many numbers you wanna calculate";

public const string GenderGuesserMenu =
@"You have selected the Gender guesser
 Next you have to answer these follow questions to guess your gender
 If you're a men type whatever number between 1 and 10 ";

 public const string InitializeContactStorageMenu = 
 @"
 -----------------------
 Register a contact
 Show contact
 Does contact exist?
 Eliminate a contact
 --------------------"     ;
 public const string NumOrganizerMenu =
 @" 
Welcome to your ordanizer number.... you're limited to 4 numbers 
Console.WriteLinePlease enter numbers that you want organize"     ;
        
public const string ContactRegister = 
@"Contact: {0} FirstName: {1} LastName: {2} +
Age: {3} Number: {4} WorkNumber: {5} Address: {6}";
    }
}
