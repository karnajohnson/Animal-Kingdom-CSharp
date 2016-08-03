/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the Eagle class.
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
    //Eagle Class
    public sealed class Eagle : Bird
    {
        #region Private Fields...
        private bool _hastalons;
        private bool _ispredatory;
        private bool _hastelescopicvision;
        private EagleGROUPS _eagleGroup;
        #endregion

        #region Properties...
        //Property for the private field _hastalons
        public bool HasTalons
        {
            //get method for _hastalons
            get
            {
                //returning _hastalons
                return this._hastalons;
            }
            //set method for _hastalons
            set
            {
                //setting _hastalons to the
                //value it is going to be set to
                this._hastalons = value;
            }
        }//end of HasTalons Property

        //Property for the private field _ispredatory
        public bool IsPredatory
        {
            //get method for _ispredatory
            get
            {
                //returning _ispredatory
                return this._ispredatory;
            }
            //set method for _ispredatory
            set
            {
                //setting _ispredatory to the
                //value it is going to be set to
                this._ispredatory = value;
            }
        }//end of IsPredatory Property

        //Property for the private field _hastelescopicvision
        public bool HasTelescopicVision
        {
            //get method for _hastelescopicvision
            get
            {
                //returning _hastelescopicvision
                return this._hastelescopicvision;
            }
            //set method for _hastelescopicvision
            set
            {
                //setting _hastelescopicvision to the
                //value it is going to be set to
                this._hastelescopicvision = value;
            }
        }//end of HasTelescopicVision Property

        public enum EagleGROUPS
        {
            UNKNOWN,
            FISH,
            BOOTED,
            SNAKE,
            HARPY
        }

        public EagleGROUPS EagleGroup
        {
            get
            {
                return this._eagleGroup;
            }
            set
            {
                this._eagleGroup = value;
            }
        }
        #endregion

        #region Constructors...
        public Eagle()
        {
            //initializing the Eagle fields
            _hastalons = true;
            _ispredatory = true;
            _hastelescopicvision = true;
            _eagleGroup = EagleGROUPS.UNKNOWN;
            //printing to the screen that the Eagle class has been initialized.
            Utilities.LogIt("This is to confirm that the Eagle class has been initialized.\n");
        }//end of Eagle Constructor
        #endregion

        #region Override Eat Methods...
        //default override eat method
        public override void Eat()
        {
            Utilities.LogIt("Eagles eat to survive.\n");
            base.Eat();
        }

        //Second Overriden Eat Method
        public override void Eat(string food)
        {
            Utilities.LogIt("Our eagle is eating " + food + " to survive.\n");
            base.Eat(food);
        }

        //Third Overriden Eat Method
        public override void Eat(string food, string how)
        {
            Utilities.LogIt("Our eagle is eating " + food +
                " with " + how + " to survive.\n");
            base.Eat(food, how);
        }
        #endregion

        #region Other Methods...
        //StunVictim Method | Simply printing out to the screen that the eagle is stunning its victim.
        public void StunVictim()
        {
            //printing a saying to the screen
            Utilities.LogIt("The eagle is stunning its victim.\n");
        }

        //Soar Method | Simply printing out to the screen that the eagle is soaring through the sky. 
        public void Soar()
        {
            //printing a saying to the screen
            Utilities.LogIt("The eagle is soaring through the sky.\n");
        }
        #endregion
    }//end of Eagle class
}//end of namespace
