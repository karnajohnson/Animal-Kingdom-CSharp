/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the Duck class.
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
    //Duck class
    public sealed class Duck : Bird
    {
        #region Private Fields...
        private string _color;
        private string _type;
        private DuckTYPE _myDuckType;
        #endregion

        #region Properties...
        //Property for the private field _color
        public string Color
        {
            //get method for _color
            get
            {
                //returning _color
                return this._color;
            }
            //set method for _color
            set
            {
                //setting _color to the
                //value it is going to be set to
                this._color = value;
            }
        }//end of Color Property

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

        public enum DuckTYPE
        {
            UNKNOWN,
            DABBLING,
            DIVING,
            EIDER,
            GOLDENEYE,
            MERGANSER,
            PERCHING,
            SCOTER,
            SEA,
            STIFFTAIL,
            TEAL,
            WHISTLING,
            DOMESTIC
        }

        public DuckTYPE MyDuckType
        {
            get
            {
                return this._myDuckType;
            }
            set
            {
                this._myDuckType = value;
            }
        }
        #endregion

        #region Constructors...
        public Duck()
        {
            //initializing the Duck fields
            _color = "green";
            _type = "Mallard";
            _myDuckType = DuckTYPE.DIVING;
            //printing to the screen that the Duck class has been initialized.
            Utilities.LogIt("This is to confirm that the Duck class has been initialized.\n");
        }//end of Duck Constructor
        #endregion

        #region Override Eat Methods...
        //default override eat method
        public override void Eat()
        {
            Utilities.LogIt("Ducks eat to survive.\n");
            base.Eat();
        }

        //Second Overriden Eat Method
        public override void Eat(string food)
        {
            Utilities.LogIt("Our duck is eating " + food + " to survive.\n");
            base.Eat(food);
        }

        //Third Overriden Eat Method
        public override void Eat(string food, string how)
        {
            Utilities.LogIt("Our duck is eating " + food +
                " with " + how + " to survive.\n");
            base.Eat(food, how);
        }
        #endregion

        #region Other Methods...
        //Swim Method | Simply printing out to the screen that the duck is swimming.
        public void Swim()
        {
            //printing a saying to the screen
            Utilities.LogIt("The duck is swimming.\n");
            if (this._myDuckType == DuckTYPE.DIVING)
                Utilities.LogIt("The duck is a diving duck.\n");
        }

        //GetBeakSlappedOff Method | Simply printing out to the screen that Daffy Duck got his beak slapped off. 
        public void GetBeakSlappedOff()
        {
            //printing a saying to the screen
            Utilities.LogIt("Daffy Duck got his beak slapped off.\n");
        }
        #endregion
    }//end of Duck class
}//end of namespace
