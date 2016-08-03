/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the Trout class.
*/

//using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuliva.com.AK.Utilities;

//namespace Tuliva.com.AnimalKingdom.Hierarchy
namespace Tuliva.com.AnimalKingdom.Hierarchy
{
    //Trout Class
    public sealed class Trout : Fish
    {
        #region Private Fields...
        private string _type;
        private string _diet;
        private TroutHabitatLOCATION _troutHabitatLocation;
        #endregion

        #region Properties...
        //Property for the private field _type
        public string Type
        {
            //get method for _type
            get
            {
                //returning _type
                return this._type;
            }
            //set method for _type
            set
            {
                //setting _type to the
                //value it is going to be set to
                this._type = value;
            }
        }//end of Type Property

        //Property for the private field _diet
        public string Diet
        {
            //get method for _diet
            get
            {
                //returning _diet
                return this._diet;
            }
            //set method for _diet
            set
            {
                //setting _diet to the
                //value it is going to be set to
                this._diet = value;
            }
        }//end of Diet Property

        public enum TroutHabitatLOCATION
        {
            UNKNOWN,
            NORTH_AMERICA,
            NORTHERN_ASIA,
            EUROPE,
            AUSTRALIA,
            NEW_ZEALAND
        }

        public TroutHabitatLOCATION TroutHabitatLocation
        {
            get
            {
                return this._troutHabitatLocation;
            }
            set
            {
                this._troutHabitatLocation = value;
            }
        }
        #endregion

        #region Constructors...
        //default constructor
        public Trout()
        {
            //initializing the Trout Fields
            _type = "Rainbow Trout";
            _diet = "Small Fish";
            _troutHabitatLocation = TroutHabitatLOCATION.UNKNOWN;
            //printing to the screen that the Trout class has been initialized.
            Utilities.LogIt("This is to confirm that the Trout class has been initialized.\n");
        }//end of Trout Constructor
        #endregion

        #region Override Eat Methods...
        //default override eat method
        public override void Eat()
        {
            Utilities.LogIt("Trouts eat to survive.\n");
            base.Eat();
        }

        //Second Overriden Eat Method
        public override void Eat(string food)
        {
            Utilities.LogIt("Our trout is eating " + food + " to survive.\n");
            base.Eat(food);
        }

        //Third Overriden Eat Method
        public override void Eat(string food, string how)
        {
            Utilities.LogIt("Our trout is eating " + food +
                " with " + how + " to survive.\n");
            base.Eat(food, how);
        }
        #endregion

        #region Other Methods...
        //AvoidAnglers Method | simply printing out that the trout is avoid anglers.
        public void AvoidAnglers()
        {
            //printing a saying to the screen 
            Utilities.LogIt("The trout is avoiding anglers.\n");
        }

        //StealBait Method | simply printing out that the trout is stealing bait.
        public static void StealBait()
        {
            //printing a saying to the screen 
            Utilities.LogIt("The trout is stealing bait.\n");
        }
        #endregion
    }//end of Trout class
}//end of namespace
