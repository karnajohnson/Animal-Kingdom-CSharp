/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the Animal class.
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
    //Animal Class
    public abstract class Animal
    {
        #region Private Fields...
        //private fields start with an underscore
        //to let the programmer know that it is private
        private string _name;
        private int _age;
        private GenderTYPE _gender;
        #endregion
        #region ENUM

        public enum GenderTYPE
        {
            UNKNOWN,
            MALE,
            FEMALE,
            HERMAPHRODITE
        }
        #endregion
        #region Properties...
        //Property for the private field _name
        public string Name
        {
            //Get method to get the name
            get
            {
                //returning _name
                return this._name;
            }
            //set method to set _name
            set
            {
                //setting _name to the value it was 
                //set to.
                this._name = value;
            }
        }//end of Name Property
        
        //Property for the private field _age
        public int Age
        {
            //Get method to get the age
            get
            {
                //returning _age
                return this._age;
            }
            //set method to set _age
            set
            {
                //setting _age to the value it was 
                //set to.
                this._age = value;
            }
        }//end of Age property

        public GenderTYPE GenderType
        {
            get
            {
                return this._gender;
            }
            set
            {
                this._gender = value;
            }
        }
        #endregion

        #region Constructor...
        public Animal()
        {
            //initializing the private fields
            _name = "default-animal";
            _age = 5;
            _gender = GenderTYPE.UNKNOWN;
            //printing to the screen that the Animal class has been initialized.
            Utilities.LogIt("This is to confirm that the Animal class has been initialized.\n");
        }//end of Animal constructor
        #endregion

        #region Eat Methods...
        //Default Abstract Eat Method
        public abstract void Eat();
        //{
        //printing a saying to the screen
        //   System.Console.WriteLine("In general, animals eat to survive.\n");
        //}

        //Overloaded Abstract Eat Method 1
        public abstract void Eat(string food);
        //{
        //    Console.WriteLine("Our animal is eating " + food + " to survive.\n");
        //}

        //Overloaded Abstract Eat Method 2
        public abstract void Eat(string food, string how);
        //{
        //    Console.WriteLine("Our animal is eating " + food +
        //        " with " + how + " to survive.\n");
        //}
        #endregion

        #region Other Methods...
        //Play Method | Simply printing out to the screen that the animal is playing 
        public void Reproduce()
        {
            //printing a saying to the screen
            Utilities.LogIt("The animal is reproducing.\n");
            _gender = GenderTYPE.FEMALE;
        }

        //Move Method | Simply printing out that the animal is moving.
        public void Move()
        {
            //printing a saying to the screen
            Utilities.LogIt("The animal is moving.\n");
        }
        #endregion

    }//end of Animal Class
}//end of Namespace
