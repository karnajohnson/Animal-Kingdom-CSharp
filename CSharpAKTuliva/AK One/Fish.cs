/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the Fish class.
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
    //Fish Class
    public abstract class Fish : Animal
    {
        #region Private Fields...
        private bool _canlayeggs;
        private bool _hasscales;
        private FishWaterTYPE _fishWaterType;
        #endregion

        #region Properties...
        //Property for the private field _canlayeggs
        public bool CanLayEggs
        {
            //get method for _canlayeggs
            get
            {
                //returning _canlayeggs
                return this._canlayeggs;
            }
            //set method for _canlayeggs
            set
            {
                //setting _canlayeggs to the
                //value it is going to be set to
                this._canlayeggs = value;
            }
        }//end of CanLayEggs Property

        //Property for the private field _hasscales
        public bool HasScales
        {
            //get method for _hasscales
            get
            {
                //returning _hasscales
                return this._hasscales;
            }
            //set method for _hasscales
            set
            {
                //setting _hasscales to the
                //value it is going to be set to
                this._hasscales = value;
            }
        }//end of HasScales Property

        public enum FishWaterTYPE
        {
            FRESH_WATER,
            SEA_WATER
        }

        public FishWaterTYPE FishWaterType
        {
            get
            {
                return this._fishWaterType;
            }
            set
            {
                this._fishWaterType = value;
            }
        }
        #endregion

        #region Constructors...
        public Fish()
        {
            //initializing the Fish Fields
            _canlayeggs = true;
            _hasscales = true;
            _fishWaterType = FishWaterTYPE.SEA_WATER;

            //printing to the screen that the Fish class has been initialized.
            Utilities.LogIt("This is to confirm that the Fish class has been initialized.\n");
        }//end of Fish Constructor
        #endregion

        #region Override Eat Methods...
        //default override eat method
        public override void Eat()
        {
            Utilities.LogIt("Fish eat to survive.\n");
            //base.Eat();
        }

        //Second Overriden Eat Method
        public override void Eat(string food)
        {
            Utilities.LogIt("Our fish is eating " + food + " to survive.\n");
            //base.Eat(food);
        }

        //Third Overriden Eat Method
        public override void Eat(string food, string how)
        {
            Utilities.LogIt("Our fish is eating " + food +
                " with " + how + " to survive.\n");
            //base.Eat(food, how);
        }
        #endregion

        #region Other Methods...
        //LayEggs Method | simply printing out that the fish is laying eggs.
        public void LayEggs()
        {
            //printing a saying to the screen 
            Utilities.LogIt("The fish is laying eggs.\n");
        }

        //Swim Method |Making it static because most animals can swim | simply printing out that the fish is swimming.
        public void Swim()
        {
            //printing a saying to the screen 
            Utilities.LogIt("The fish is swimming.\n");
            if (this._fishWaterType == FishWaterTYPE.FRESH_WATER)
                Utilities.LogIt("The fish is swimming in fresh water.\n");
            else
                Utilities.LogIt("The fish is swimming in sea water.\n");
        }

        //GiveLiveBirth Method | Making it static because some animals give live birth
        public static void GiveLiveBirth(string animal)
        {
            //printing a saying to the screen 
            Utilities.LogIt("The " + animal + " is giving live birth.\n");
        }
        #endregion
    }//End of Fish Class
}//End of Namespace
