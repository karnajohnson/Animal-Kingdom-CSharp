//SCORING FOR H/W AFTER WEEK 5 160417
// 1)                                       +12      
// 2)                                       +10
// 3)
//      A) DECL Fields                      + 20
//      B) DEF Fields                       + 10
//      C) DECL Methods                     + 20
//      D) Def methods                      + 20
//      E) Pub,Priv, Prot                   + 10
// 4) Constructors                          + 20
// 5) Inherit.                              + 7
// 6) walk. eat                             + 12
// 8) Abstract & Sealed                     + 10
// 9) Props                                 + 20
// 10) Enum                                 + 10
// 11) Util                                 + 4
// TOTAL FOR THIS HOMEWORK                          +      185/185                

/*
   Name of Programmer: Karna Johnson
   Date: 4/7/2016
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the main program class.
*/

//using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tuliva.com.AnimalKingdom.Hierarchy;
using Tuliva.com.AK.Utilities;
using Tuliva.com.AnimalKingdom.Clients;
using System.Windows.Forms;
using Tuliva.com.AnimalKingdom.Exceptions;

//namespace Tuliva.com.AnimalKingdom.Runtime
namespace Tuliva.com.AnimalKingdom.Runtime
{
    //Program Class
    public class Program
    {
        //Main Method
        public static void Main()
        {
            //bool for continuing the program
            bool pleaseContinue = true;
            //string reply for what the user inputs
            string reply = "";
            //a do-while loop for the menu
            do
            {
                //using a method to display the menu
                DisplayMenu();
                //getting input from the user using a method
                reply = Input(); 
                //a switch case for the menu
                switch (reply)
                {
                    //case 1 for the NoClient menu
                    case "1":
                        //clearing the screen with a method that was created
                        ClearScreen();
                        //calling the NoClient's main method for its menu 
                        NoClient.NoClientMain();
                        //breaking from the case
                        break;
                    //case 2 for the MenuClientMain
                    case "2":
                        //clearing the screen with a method that was created
                        ClearScreen();
                        //calling the MenuClient's main method for its menu
                        MenuClient.MenuClientMain();
                        //breaking from the case
                        break;
                    //case 3 for the FormClient
                    case "3":
                        //clearing the screen with a method that was created
                        ClearScreen();
                        //have a try and catch here because if the user wants to
                        //get the form again after it has runned, an exception happens
                        //which is a InvalidOperationException. 
                        try
                        {
                            //enabling visual styles
                            Application.EnableVisualStyles();
                            //setting compatibility with text rendering
                            //you can only do this once in the program. 
                            //That's why there is a try catch block. 
                            Application.SetCompatibleTextRenderingDefault(false);
                            //run the form
                            Application.Run(new AK_One.FormClient());
                        }
                        catch (InvalidOperationException)
                        {
                            //run the form again if the user has selected to run the form in 
                            //the menu more than once
                            Application.Run(new AK_One.FormClient());
                        }
                        //breaking from the case
                        break;
                    //This case 4 is the exit
                    case "4":
                        //clearing the screen with a method that was created
                        ClearScreen();
                        //setting the bool to false to let the loop know to exit
                        pleaseContinue = false;
                        //logging that the user exited the menu.
                        Utilities.LogIt("Program::The user exited the program menu.\n",
                               Utilities.MessageSeverity.INFORMATIONAL, true);
                        //breaking from the case
                        break;
                    //default case
                    default:
                        //clearing the screen with a method that was created
                        ClearScreen();
                        //try to throw a new exception
                        try
                        {
                            //throwing my custom exception
                            throw new CustomExceptions();
                        }
                        //catching the exception
                        catch (CustomExceptions)
                        {
                            //logging the exception
                            Utilities.LogIt("You entered an invalid option in the main menu!\nTry again!\n",
                                Utilities.MessageSeverity.ERROR, true);
                        }
                        //breaking from the case
                        break;
                }//end of switch case
            //end of while loop if pleaseContinue is false
            } while (pleaseContinue);
            
        }//end of main method

        //Method for displaying the menu
        public static void DisplayMenu()
        {
            //printing out to the screen the menu
            Utilities.LogIt("Hi! Welcome to the Animal Kingdom!!\n" +
                "Choose from the following options for which menu you want to do.\n" +
                "1) NoClientMain\n" +
                "2) MenuMain\n" +
                "3) FormClient\n" +
                "4) Exit\n");
        }
        //ClearScreen Method | Clearing the screen
        public static void ClearScreen()
        {
            //clearing the console
            Console.Clear();
        }
        //Input Method | getting input from the user
        public static string Input()
        {
            //declaring a variable message
            string message = "";
            //getting input from the console into message
            message = Console.ReadLine();
            //returning message
            return message;
        }
    }//end of program class
}//end of namespace
