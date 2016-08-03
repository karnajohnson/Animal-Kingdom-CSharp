/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the Human class.
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
    //Human Class
    public sealed class Human : Primate
    {
        #region Private Fields...
        private string _jobtitle;
        private double _salary;
        private bool _hasJob;
        private HumanGenderTYPE _humanGenderType;
        #endregion

        #region Properties...
        //Property for the private field _jobtitle
        public string JobTitle
        {
            //get method for _jobtitle
            get
            {
                //returning _jobtitle
                return this._jobtitle;
            }
            //set method for _jobtitle
            set
            {
                //setting _jobtitle to the
                //value it is going to be set to
                this._jobtitle = value;
            }
        }//end of JobTitle Property

        //Property for the private field _salary
        public double Salary
        {
            //get method for _salary
            get
            {
                //returning _salary
                return this._salary;
            }
            //set method for _salary
            set
            {
                //setting _salary to the
                //value it is going to be set to
                this._salary = value;
            }
        }//end of Salary Property

        public enum HumanGenderTYPE
        {
            MALE,
            FEMALE
        }

        public HumanGenderTYPE HumanGenderType
        {
            get
            {
                return this._humanGenderType;
            }
            set
            {
                this._humanGenderType = value;
            }
        }
        #endregion

        #region Constructors...
        public Human()
        {
            //initializing the private Human Fields
            _jobtitle = "Programmer";
            _salary = 65000;
            _hasJob = true;
            _humanGenderType = HumanGenderTYPE.MALE;
            //printing to the screen that the Human class has been initialized.
            System.Console.WriteLine("This is to confirm that the Human class has been initialized.\n");
        }//end of Human Constructor
        #endregion

        #region Override Eat Methods...
        //default override eat method
        public override void Eat()
        {
            //printing to the screen
            Utilities.LogIt("Humans eat to survive.\n");
            base.Eat();
        }

        //Second Overriden Eat Method
        public override void Eat(string food)
        {
            //printing to the screen
            Utilities.LogIt("Our human is eating " + food + " to survive.\n");
            base.Eat(food);
        }

        //Third Overriden Eat Method
        public override void Eat(string food, string how)
        {
            //printing to the screen
            Utilities.LogIt("Our human is eating " + food +
                " with " + how + " to survive.\n");
            base.Eat(food, how);
        }
        #endregion

        #region Other Methods...
        //Work Method | simply printing out that the human is working.

        public void Work()
        {
            //printing a saying to the screen 
            Utilities.LogIt("The human is working.\n");
            if (this._humanGenderType == HumanGenderTYPE.MALE)
                Utilities.LogIt("The some males usually do harder labor work.\n");
            else
                Utilities.LogIt("The some females usually do office jobs.\n");
        }

        //Play Method | simply printing out that the human is playing.
        public void Play()
        {
            //printing a saying to the screen 
            Utilities.LogIt("The human is playing.\n");
            if (this._humanGenderType == HumanGenderTYPE.FEMALE)
                Utilities.LogIt("The female is playing with the kids.\n");
            else
                Utilities.LogIt("The male is playing with his buddys.\n");
        }
        #endregion
    }//end of Human Class
}//end of namespace
