/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Having a menu for the old code 
   Class: This is the NoClient class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuliva.com.AnimalKingdom.Hierarchy;
using Tuliva.com.AK.Utilities;
using Tuliva.com.AnimalKingdom.Exceptions;

namespace Tuliva.com.AnimalKingdom.Clients
{
    public class NoClient
    {
        public static void NoClientMain()
        {
            #region Old Code...
            ////Animal Object Declaration
            ////old way of non-abstract class
            ////Animal myAnimal = new Animal();
            ////Mammal Object Declaration
            ////Mammal myMammal = new Mammal();
            ////Primate Object Declaration
            ////Primate myPrimate = new Primate();
            ////Human Object Declaration
            //Human myHuman = new Human();
            ////Bird Object Declaration
            ////Bird myBird = new Bird();
            ////Duck Object Declaration
            //Duck myDuck = new Duck();
            ////Eagle Object Declaration
            ////Eagle myEagle = new Eagle();
            ////Fish Object Declaration
            ////Fish myFish = new Fish();
            ////Trout Object Declaration
            //Trout myTrout = new Trout();
            ////Shark Object Declaration
            ////Shark myShark = new Shark();

            //////Animal Method calls
            //////myAnimal.Eat();
            //////myAnimal.Reproduce();
            //////myAnimal.Move();

            //////Mammal Method calls
            //////myMammal.Nurse();
            //////myMammal.GiveLiveBirth();

            //////Primate Method calls
            //////myPrimate.UseLargeBrain();
            //////myPrimate.SwingFromTrees();
            //////myPrimate.FierclyProtectTerritory();

            //////Human Method calls
            //myHuman.Work();
            //myHuman.Play();
            //myHuman.Eat();
            //myHuman.Eat("chicken");
            //myHuman.Eat("mashed potatoes and green beans", "utensils");


            //////Bird Method calls
            //////myBird.LayEggs();
            //////myBird.Fly();

            //////Duck Method calls
            //myDuck.Swim();
            //myDuck.GetBeakSlappedOff();
            //myDuck.Eat();
            //myDuck.Eat("grass");
            //myDuck.Eat("grass", "mouth");
            ////Eagle Method calls
            ////myEagle.StunVictim();
            ////myEagle.Soar();

            ////Fish Method calls
            ////myFish.LayEggs();
            ////myFish.Swim();
            ////myFish.GiveLiveBirth();

            ////Trout Method calls

            ////Shark Method calls
            //myShark.KeepMovingToBreathe();
            //myShark.AttackBoats();
            #endregion
            bool pleaseContinue = true;
            //field for the menu
            string reply = "";
            //a do while declaration
            do
            {
                //displaying the menu
                DisplayMenu();
                //getting input from the user
                reply = Input();
                //using a switch case for their answer
                switch (reply)
                {
                    //case 1 | Human
                    case "1":
                        //clearing the screen
                        ClearScreen();
                        //creating a new human
                        Human myHuman = new Human();
                        myHuman.Name = "Karna";
                        myHuman.Age = 25;
                        myHuman.Work();
                        myHuman.Play();
                        myHuman.Eat();
                        myHuman.Eat("chicken");
                        myHuman.Eat("mashed potatoes and green beans", "utensils");
                        Utilities.LogIt("NoClient::The user instantiated a human.\n",
                                Utilities.MessageSeverity.INFORMATIONAL, true);
                        //making sure to break 
                        break;
                    //case 2 | Duck
                    case "2":
                        //clearing the screen
                        ClearScreen();
                        //creating a new Duck
                        Duck myDuck = new Duck();
                        myDuck.Name = "Mallard";
                        myDuck.Age = 2;
                        myDuck.Swim();
                        myDuck.GetBeakSlappedOff();
                        myDuck.Eat();
                        myDuck.Eat("grass");
                        myDuck.Eat("grass", "mouth");
                        Utilities.LogIt("NoClient::The user instantiated a duck.\n",
                                Utilities.MessageSeverity.INFORMATIONAL, true);
                        break;
                    //case 3 | Trout
                    case "3":
                        //clearing the screen
                        ClearScreen();
                        //creating a new Trout
                        Trout myTrout = new Trout();
                        myTrout.Name = "Rainbow";
                        myTrout.Age = 1;
                        myTrout.AvoidAnglers();
                        myTrout.Eat();
                        myTrout.Eat("baby fish");
                        myTrout.Eat("baby fish", "mouth");
                        Utilities.LogIt("NoClient::The user instantiated a trout.\n",
                                Utilities.MessageSeverity.INFORMATIONAL, true);
                        break;
                    //Case 4 | Exit
                    case "4":
                        //clearing the screen
                        ClearScreen();
                        //creating a new Platypus
                        ComposedPlatypus myPlat = new ComposedPlatypus();
                        myPlat.DuckPART.Name = "Platy";
                        myPlat.TroutPART.Age = 1;
                        myPlat.LayEggs();
                        myPlat.SwimLikeDuck();
                        myPlat.SwimLikeFish();
                        myPlat.Nurse();
                        Utilities.LogIt("NoClient::The user instantiated a platypus.\n",
                                Utilities.MessageSeverity.INFORMATIONAL, true);
                        break;
                    //Case 5 | Exit
                    case "5":
                        //clearing the screen
                        ClearScreen();
                        //setting pleaseContinue to false
                        pleaseContinue = false;
                        //logging that the user exited the menu.
                        Utilities.LogIt("NoClient::The user exited the NoClient's menu.\n",
                                Utilities.MessageSeverity.INFORMATIONAL, true);
                        //breaking from the case
                        break;
                    //the default case
                    default:
                        //clearing the screen
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
                            Utilities.LogIt("You entered an invalid option in the NoClient menu!\nTry again!\n",
                                Utilities.MessageSeverity.ERROR, true);
                        }
                        //breaking from the case
                        break;
                }
                //while pleaseContinue is true
            } while (pleaseContinue);
        }
        //DisplayMenu Method | Displaying the menu

        public static void DisplayMenu()
        {
            //having a message that displays the menu
            string message = "Hi! You are in the NoClient menu!\n" +
                "Please select from the following which animal you want to instansiate.\n" +
                "1) Human\n" +
                "2) Duck\n" +
                "3) Trout\n" +
                "4) Platypus\n" +
                "5) Exit\n";
            //writing it to the screen
            Console.WriteLine(message);
        }
        //ClearScreen Method | Clearing the screen
        public static void ClearScreen()
        {
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
    }
}
