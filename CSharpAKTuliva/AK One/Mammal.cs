/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the Mammal class.
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
    //Mammal Class
    public abstract class Mammal : Animal
    {
        #region Private Fields...
        private bool _iswarmblooded;
        private bool _hashairorfur;
        private MammalTYPE _myMammalType;
        #endregion

        #region Properties...
        //Property for the private field _iswarmblooded
        public bool IsWarmBlooded
        {
            //get method for _iswarmblooded
            get
            {
                //returning _iswarmblooded
                return this._iswarmblooded;
            }
            //set method for _iswarmblooded
            set
            {
                //setting _iswarmblooded to the
                //value it is going to be set to
                this._iswarmblooded = value;
            }
        }//end of IsWarmBlooded Property

        //Property for the private field _hashairorfur
        public bool HasHairOrFur
        {
            //get method for _hashairorfur
            get
            {
                //returning _hashairorfur
                return this._hashairorfur;
            }
            //set method for _hashairorfur
            set
            {
                //setting _hashairorfur to the 
                //value it is going to be set to
                this._hashairorfur = value;
            }
        }//end of HasHairOrFur Property

        public enum MammalTYPE
        {
            MONOTREME,
            MARSUPIAL,
            PLACENTAL
        }
        public MammalTYPE MammalType
        {
            get
            { 
                return this._myMammalType;
            }

            set
            {
                this._myMammalType = value;
            }
        }
        #endregion

        #region Constructor...
        public Mammal()
        {
            //initializing the private fields
            _iswarmblooded = true;
            _hashairorfur = true;
            _myMammalType = MammalTYPE.PLACENTAL;

            //printing out to the screen that the mammal class has been initialized.
            Utilities.LogIt("This is to confirm that the Mammal class has been initialized.\n");
        }//end of Mammal Constructor
        #endregion

        #region Override Eat Methods...
        //default override eat method
        public override void Eat()
        {
            //printing to the screen
            Console.WriteLine("Mammals eat to survive.\n");
            //base.Eat();
        }

        //Second Overriden Eat Method
        public override void Eat(string food)
        {
            //printing to the screen
            Console.WriteLine("Our mammal is eating " + food + " to survive.\n");
            //base.Eat(food);
        }

        //Third Overriden Eat Method
        public override void Eat(string food, string how)
        {
            //printing to the screen
            Console.WriteLine("Our mammal is eating " + food +
                " with " + how + " to survive.\n");
            //base.Eat(food, how);
        }
        #endregion
        
        #region Other Methods...
        //GiveLiveBirth Method | simply printing out that the mammal is giving birth.
        public void GiveLiveBirth()
        {
            //printing a saying to the screen 
            //System.Console.WriteLine("The mammal is giving birth.\n");
            if (this._myMammalType == MammalTYPE.PLACENTAL)
                Utilities.LogIt("Mammal is giving birth to live young");
            else
                Utilities.LogIt("This type a mammal," +
                    this._myMammalType.ToString() + ", does NOT give live birth.");
        }
        //Nurse Method | simply printing out that the mammal is nursing.
        public static void Nurse()
        {
            //printing a saying to the screen 
            Utilities.LogIt("The mammal is nursing.\n");
        }
        #endregion
        
    }//end of mammal class
}//end of namespace
