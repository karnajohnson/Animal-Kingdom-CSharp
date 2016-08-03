/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Creating a menu for the client. 
   Class: This is the MenuClient class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuliva.com.AnimalKingdom.Hierarchy;
using Tuliva.com.AnimalKingdom.Base;
using Tuliva.com.AK.Utilities;
using Tuliva.com.AnimalKingdom.Exceptions;
using Tuliva.com.AnimalKingdom.Collections;

namespace Tuliva.com.AnimalKingdom.Clients
{
    public class MenuClient
    {
        public static void MenuClientMain()
        {
            bool pleaseContinue = true;
            //field for the menu
            string reply = "";
            string replyZoo = "";
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
                        //clear the screen
                        ClearScreen();
                        //create a new base human
                        BaseHuman aHuman = BaseHuman.getDecoupledHuman();
                        //using the interfaces
                        aHuman.Name("Karna");
                        aHuman.Age(25);
                        aHuman.Gender("female");
                        aHuman.Eat();
                        aHuman.Eat("spagetti");
                        aHuman.Eat("spagetti", "utensils");
                        aHuman.Fly();
                        aHuman.Fly(35000);
                        aHuman.Swim();
                        aHuman.Swim(10);
                        aHuman.Reproduce();
                        aHuman.Reproduce(2);
                        aHuman.Move();
                        aHuman.Move(8);
                        //LogIt method saying that the user instantiated a BaseHuman
                        Utilities.LogIt("MenuClient::The user instantiated a BaseHuman.\n",
                                Utilities.MessageSeverity.INFORMATIONAL, true);
                        #region Old Code for Human...
                        //Human aHuman = new Human();
                        //aHuman.Name = "Karna";
                        //aHuman.Age = 25;
                        //aHuman.BrainSize = Primate.BrainSIZE.HUMAN_LARGE;
                        //aHuman.GenderType = Animal.GenderTYPE.FEMALE;
                        //aHuman.HasHairOrFur = true;
                        //aHuman.HasOpposableThumbs = true;
                        //aHuman.IsWarmBlooded = true;
                        //aHuman.JobTitle = "Programmer";
                        //aHuman.Salary = 65432;
                        //aHuman.Eat();
                        //aHuman.Eat("mashed potatoes");
                        //aHuman.Eat("mashed potatoes", "utensils");
                        //aHuman.Reproduce();
                        //aHuman.Play();
                        //aHuman.Move();
                        //aHuman.Work();
                        #endregion
                        //making sure to break 
                        break;
                    //case 2 | Duck
                    case "2":
                        //clearing the screen
                        ClearScreen();
                        //create a new base Duck
                        BaseDuck aDuck = BaseDuck.getDecoupledDuck();
                        //using the interfaces
                        aDuck.Name("Daffy");
                        aDuck.Age(2);
                        aDuck.Gender("Male");
                        aDuck.Eat();
                        aDuck.Eat("fish");
                        aDuck.Eat("fish", "mouth");
                        aDuck.Reproduce();
                        aDuck.Reproduce(5);
                        aDuck.Fly();
                        aDuck.Fly(500);
                        aDuck.Swim();
                        aDuck.Swim(1);
                        aDuck.Move();
                        aDuck.Move(2);
                        //LogIt method saying that the user instantiated a BaseDuck
                        Utilities.LogIt("MenuClient::The user instantiated a BaseDuck.\n",
                                Utilities.MessageSeverity.INFORMATIONAL, true);
                        #region Old Code For Duck...
                        //Duck aDuck = new Duck();
                        //aDuck.Name = "Joe";
                        //aDuck.Age = 2;
                        //aDuck.BirdAnatomy = Bird.BirdANATOMY.FEATHERS;
                        //aDuck.CanFly = true;
                        //aDuck.Color = "green";
                        //aDuck.GenderType = Animal.GenderTYPE.MALE;
                        //aDuck.IsAquatic = false;
                        //aDuck.Type = "Mallard";
                        //aDuck.Swim();
                        //aDuck.Reproduce();
                        //aDuck.Move();
                        //aDuck.LayEggs();
                        //aDuck.Fly();
                        //aDuck.Eat();
                        //aDuck.Eat("fish");
                        //aDuck.Eat("fish", "mouth");
                        #endregion
                        break;
                    //case 3 | Trout
                    case "3":
                        //clearing the screen
                        ClearScreen();
                        //create a new base Trout
                        BaseTrout aTrout = BaseTrout.getDecoupledTrout();
                        //using the interfaces
                        aTrout.Name("Phil");
                        aTrout.Age(1);
                        aTrout.Gender("Male");
                        aTrout.Eat();
                        aTrout.Eat("fish");
                        aTrout.Eat("fish", "mouth");
                        aTrout.Reproduce();
                        aTrout.Reproduce(15);
                        aTrout.Swim();
                        aTrout.Swim(4);
                        aTrout.Move();
                        aTrout.Move(3);
                        //LogIt method saying that the user instantiated a BaseTrout
                        Utilities.LogIt("MenuClient::The user instantiated a BaseTrout.\n",
                                Utilities.MessageSeverity.INFORMATIONAL, true);
                        #region Old Code for Trout...
                        //Trout aTrout = new Trout();
                        //aTrout.Name = "Adele";
                        //aTrout.Age = 3;
                        //aTrout.CanLayEggs = true;
                        //aTrout.Diet = "other fish";
                        //aTrout.FishWaterType = Fish.FishWaterTYPE.FRESH_WATER;
                        //aTrout.GenderType = Animal.GenderTYPE.FEMALE;
                        //aTrout.HasScales = true;
                        //aTrout.TroutHabitatLocation = Trout.TroutHabitatLOCATION.NORTH_AMERICA;
                        //aTrout.Type = "Rainbow";
                        //aTrout.Eat();
                        //aTrout.Eat("other fish");
                        //aTrout.Eat("other fish", "mouth");
                        //aTrout.AvoidAnglers();
                        //aTrout.Swim();
                        //aTrout.Reproduce();
                        //aTrout.LayEggs();
                        #endregion
                        break;
                    //Case 4 | Zoo
                    case "4":
                        //creating a new zoo collection object
                        ZooCollection myZoo = new ZooCollection();

                        //adding objects into the collection
                        myZoo.Add(new Human());
                        myZoo.Add(new Duck());
                        myZoo.Add(new Trout());

                        //using a Each method in the ZooCollection class
                        //that has a foreach method to go through the items 
                        //and print out the different methods
                        myZoo.Each();

                        //method demonstrating the casting
                        myZoo.Cast();

                        //LogIt method saying that the user created a zoo.
                        Utilities.LogIt("MenuClient::The user created a zoo.\n",
                                 Utilities.MessageSeverity.INFORMATIONAL, true);

                        //creating a new interface zoo collection object
                        InterfaceZooCollection interfaceZoo = new InterfaceZooCollection();

                        //adding decoupled objects into the collection
                        interfaceZoo.Add(BaseHuman.getDecoupledHuman());
                        interfaceZoo.Add(BaseDuck.getDecoupledDuck());
                        interfaceZoo.Add(BaseTrout.getDecoupledTrout());

                        //using a Each method in the InterfaceZooCollection class
                        //that has a foreach method to go through the items 
                        //and print out the different methods
                        interfaceZoo.Each();

                        //method demonstrating the casting
                        interfaceZoo.Cast();

                        //LogIt method saying that the user created a zoo.
                        Utilities.LogIt("MenuClient::The user created a interface zoo.\n",
                                 Utilities.MessageSeverity.INFORMATIONAL, true);

                        //clearing the zoos
                        myZoo.Clear();
                        interfaceZoo.Clear();

                        //breaking from the case
                        break;
                    //Case 5 | Exit
                    case "5":
                        //clearing the screen
                        ClearScreen();
                        //setting pleaseContinue to false
                        pleaseContinue = false;
                        Utilities.LogIt("MenuClient::The user exited the MenuClient's menu.\n",
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
                            Utilities.LogIt("You entered an invalid option in the MenuClient menu!\nTry again!\n",
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
            string message = "Hi! You are in the MenuClient menu!\n" +
                "Please select from the following which animal you want to instansiate.\n" +
                "1) Human\n" +
                "2) Duck\n" +
                "3) Trout\n" +
                "4) Zoo\n" + 
                "5) Exit\n";
            //writing it to the screen
            Console.WriteLine(message);
        }
        //ClearScreen Method | Clearing the screen
        public static void ClearScreen()
        {
            //clearing the screen
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
