/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the Bird class.
*/

//using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuliva.com.AK.Utilities;
//namespace
namespace Tuliva.com.AnimalKingdom.Hierarchy
{
    //Bird Class
    public abstract class Bird : Animal
    {
        #region Private Fields...
        private bool _canfly;
        private bool _isaquatic;
        private BirdANATOMY _birdAnatomy;
        #endregion

        #region Properties...
        //Property for the private field _canfly
        public bool CanFly
        {
            //get method for _canfly
            get
            {
                //returning _canfly
                return this._canfly;
            }
            //set method for _canfly
            set
            {
                //setting _canfly to the
                //value it is going to be set to
                this._canfly = value;
            }
        }//end of CanFly Property

        //Property for the private field _isaquatic
        public bool IsAquatic
        {
            //get method for _isaquatic
            get
            {
                //returning _isaquatic
                return this._isaquatic;
            }
            //set method for _isaquatic
            set
            {
                //setting _isaquatic to the
                //value it is going to be set to
                this._isaquatic = value;
            }
        }//end of IsAquatic Property 

        public enum BirdANATOMY
        {
            UNKNOWN,
            SKELETAL,
            EXCRETORY,
            RESPIRATORY,
            CIRCULATORY,
            NERVOUS_SYSTEM,
            DEFENCE_COMBAT,
            INTRASPECIFIC_COMBAT,
            CHROMOSOMES,
            FEATHERS,
            PLUMAGE,
            SCALES,
            FLIGHT
        }

        public BirdANATOMY BirdAnatomy
        {
            get
            {
                return this._birdAnatomy;
            }
            set
            {
                this._birdAnatomy = value;
            }
        }
        #endregion

        #region Constructors...
        public Bird()
        {
            //initializing the Bird fields
            _canfly = true;
            _isaquatic = false;
            _birdAnatomy = BirdANATOMY.UNKNOWN;
            //printing to the screen that the Bird class has been initialized.
            Utilities.LogIt("This is to confirm that the Bird class has been initialized.\n");
        }//end of Bird Constructor
        #endregion

        #region Override Eat Methods...
        //default override eat method
        public override void Eat()
        {
            Utilities.LogIt("Birds eat to survive.\n");
            //base.Eat();
        }

        //Second Overriden Eat Method
        public override void Eat(string food)
        {
            Utilities.LogIt("Our bird is eating " + food + " to survive.\n");
            //base.Eat(food);
        }

        //Third Overriden Eat Method
        public override void Eat(string food, string how)
        {
            Utilities.LogIt("Our bird is eating " + food +
                " with " + how + " to survive.\n");
            //base.Eat(food, how);
        }
        #endregion

        #region Other Methods...
        //LayEggs Method | Simply printing out that the bird is laying eggs.
        public void LayEggs()
        {
            //printing a saying to the screen
            Utilities.LogIt("The bird is laying eggs.\n");
        }

        //Fly Method | Simply printing out to the screen that the bird is flying. 
        public void Fly()
        {
            //printing a saying to the screen
            Utilities.LogIt("The bird is flying.\n");
            this._birdAnatomy = BirdANATOMY.FLIGHT;
        }
        #endregion
    }//end of Bird Class
}//end of namespace
