/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the Shark class.
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
    //Shark Class
    public sealed class Shark : Fish
    {
        #region Private Fields...
        private bool _ispredatory;
        private double _size;
        private SharkANATOMY _sharkAnatomy;
        #endregion

        #region Properties...
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
        }//end of IsPredatroy Method

        //Property for the private field _size
        public double Size
        {
            //get method for _size
            get
            {
                //returning _size
                return this._size;
            }
            //set method for _size
            set
            {
                //setting _size to the
                //value it is going to be set to
                this._size = value;
            }
        }//end of Size Property

        public enum SharkANATOMY
        {
            UNKNOWN,
            TEETH,
            SKELETON,
            JAW,
            FINS,
            DERMAL_DENTICLES,
            TAILS,
            GILLS
        }
        
        public SharkANATOMY SharkAnatomy
        {
            get
            {
                return this._sharkAnatomy;
            }
            set
            {
                this._sharkAnatomy = value;
            }
        }
        #endregion

        #region Constructors...
        public Shark()
        {
            //initializing the Shark Fields
            _ispredatory = true;
            _size = 13.5;
            _sharkAnatomy = SharkANATOMY.GILLS;
            //printing to the screen that the Shark class has been initialized.
            Utilities.LogIt("This is to confirm that the Shark class has been initialized.\n");
        }//end of Shark Constructor
        #endregion

        #region Override Eat Methods...
        //default override eat method
        public override void Eat()
        {
            Utilities.LogIt("Sharks eat to survive.\n");
            base.Eat();
        }

        //Second Overriden Eat Method
        public override void Eat(string food)
        {
            Utilities.LogIt("Our shark is eating " + food + " to survive.\n");
            base.Eat(food);
        }

        //Third Overriden Eat Method
        public override void Eat(string food, string how)
        {
            Utilities.LogIt("Our shark is eating " + food +
                " with " + how + " to survive.\n");
            base.Eat(food, how);
        }
        #endregion

        #region Other Methods...
        //KeepMovingToBreathe Method | simply printing out that the shark has to keep moving to breathe.
        public void KeepMovingToBreathe()
        {
            //printing a saying to the screen 
            Utilities.LogIt("The shark has to keep moving to breathe and stay alive.\n");
            if (this._sharkAnatomy == SharkANATOMY.GILLS)
                Utilities.LogIt("The shark is breathing through its gills.\n");
        }

        //AttackBoats Method | simply printing out that the shark is attacking a boat.
        public void AttackBoats()
        {
            //printing a saying to the screen 
            //Utilities.LogIt("The shark is attacking a boat.\n");
            this._sharkAnatomy = SharkANATOMY.JAW;
            if (this._sharkAnatomy == SharkANATOMY.JAW)
                Utilities.LogIt("The shark is attacking the boat with its jaw.\n");
        }
        #endregion
    }//end of Shark Class
}//end of namespace
