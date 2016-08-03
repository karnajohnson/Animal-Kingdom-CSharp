/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the Primate class.
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
    //Primate Class
    public abstract class Primate : Mammal
    {
        #region Private Fields...
        private bool _hasopposablethumbs;
        private bool _haslargebrain;
        private BrainSIZE _brainSize;
        private PrimateLOCOMOTION _primateLocomotion;
        #endregion

        #region Properties and ENUMS...
        //Property for the private field _hasopposablethumbs
        public bool HasOpposableThumbs
        {
            //get method for _hasopposablethumbs
            get
            {
                //returning _hasopposablethumbs
                return this._hasopposablethumbs;
            }
            //set method for _hasopposablethumbs
            set
            {
                //setting _hasopposablethumbs to the
                //value it is going to be set to
                this._hasopposablethumbs = value;
            }
        }//end of HasOpposableThumbs Property

        //Property for the private field _haslargebrain
        public bool HasLargeBrain
        {
            //get method for _haslargebrain
            get
            {
                //returning _haslargebrain
                return this._haslargebrain;
            }
            //set method for _haslargebrain
            set
            {
                //setting _haslargebrain to the
                //value it is going to be set to
                this._haslargebrain = value;
            }
        }//end of HasLargeBrain Property

        public enum BrainSIZE
        {
            UNKNOWN,
            VERY_SMALL,
            SMALL,
            MEDIUM,
            LARGE,
            HUMAN_LARGE,
            STEPHEN_HAWKING_LARGE
        }

        public BrainSIZE BrainSize
        {
            get
            {
                return this._brainSize;
            }

            set
            {
                this._brainSize = value;
            }
        }

        public enum PrimateLOCOMOTION
        {
            UNKNOWN,
            BRACHIATION,
            BIPEDLISM,
            LEAPING,
            QUADREPEDALISM,
            CLIMBING,
            KNUCKLE_WALKING,
            SWINGING
        }

        public PrimateLOCOMOTION PrimateLocomotion
        {
            get
            {
                return this._primateLocomotion;
            }
            set
            {
                this._primateLocomotion = value;
            }
        }
        #endregion

        #region Constructor...
        public Primate()
        {
            //initializing the fields
            _hasopposablethumbs = true;
            _haslargebrain = true;
            _brainSize = BrainSIZE.UNKNOWN;
            _primateLocomotion = PrimateLOCOMOTION.UNKNOWN;

            //printing to the screen that the Primate class has been initialized.
            Utilities.LogIt("This is to confirm that the Primate class has been initialized.\n");
        }//end of Primate Constructor
        #endregion

        #region Override Eat Methods...
        //default override eat method
        public override void Eat()
        {
            //printing to the screen
            Utilities.LogIt("Primates eat to survive.\n");
            base.Eat();
        }

        //Second Overriden Eat Method
        public override void Eat(string food)
        {
            //printing to the screen
            Utilities.LogIt("Our primate is eating " + food + " to survive.\n");
            base.Eat(food);
        }

        //Third Overriden Eat Method
        public override void Eat(string food, string how)
        {
            //printing to the screen
            Utilities.LogIt("Our primate is eating " + food +
                " with " + how + " to survive.\n");
            base.Eat(food, how);
        }
        #endregion

        #region Other Methods...
        //UseLargeBrain Method | Simply printing out that the primate has a large brain and is using it.
        public void UseLargeBrain()
        {
            //printing a saying to the screen
            Utilities.LogIt("The primate has a large brain and is using it.\n");
            _brainSize = BrainSIZE.LARGE;
        }

        //SwingFromTrees Method | Simply printing out to the screen that the primate is swinging from trees. 
        public void SwingFromTrees()
        {
            //printing a saying to the screen
            if (_primateLocomotion == PrimateLOCOMOTION.SWINGING)
                Utilities.LogIt("The primate is swinging from tree to tree.\n");
            else if (_primateLocomotion == PrimateLOCOMOTION.CLIMBING)
                Utilities.LogIt("The primate is climbing the tree.\n");
            else
                Utilities.LogIt("The primate is walking.\n");
        }

        //FierclyProtectTerritory Method | Simply printing out that the primate is fiercly protecting its territory.
        public void FierclyProtectTerritory()
        {
            //printing a saying to the screen
            Utilities.LogIt("The primate is fiercly protecting its territory.\n");
        }
        #endregion
    }//end of primate class
}//end of namespace
