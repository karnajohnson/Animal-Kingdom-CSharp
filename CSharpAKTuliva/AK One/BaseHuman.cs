/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the interfaces in a base class. 
   Class: This is the BaseHuman class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuliva.com.AnimalKingdom.Interfaces;
using Tuliva.com.AK.Utilities;

//namespace Tuliva.com.AnimalKingdom.Base
namespace Tuliva.com.AnimalKingdom.Base
{
    //public sealed class BaseHuman implementing interfaces
    public sealed class BaseHuman : IEat, IReproduce, IIdentity, IFly, ISwim, IAnimal
    {
        //constructor
        private BaseHuman()
        {
            Utilities.LogIt("This is confirming that the BaseHuman class has been initialized.\n");
        }

        public static BaseHuman getDecoupledHuman()
        {
            return new BaseHuman();
        }
        //Default Eat Method from the IEat interface
        public void Eat()
        {
            Utilities.LogIt("The human is eating.\n");
        }
        //1st overloaded Eat Method from the IEat interface
        public void Eat(string food)
        {
            Utilities.LogIt("The human is eating " + food + ".\n");
        }
        //2nd overloaded Eat Method from the IEat interface
        public void Eat(string food, string how)
        {
            Utilities.LogIt("The human is eating " + food + " and is using " + how + ".\n");
        }
        //default Reproduce method from the IReproduce interface
        public void Reproduce()
        {
            Utilities.LogIt("The human is reproducing.\n");
        }
        //Overloaded Reproduce method from the IReproduce interface
        public void Reproduce(int howManyBabies)
        {
            Utilities.LogIt("The human is reproducing and had " + howManyBabies + " baby(ies).\n");
        }
        //Name Method from the IIdentity interface
        public void Name(string name)
        {
            Utilities.LogIt("The human's name is: " + name + ".\n");
        }
        //Age Method from the IIdentity interface
        public void Age(int age)
        {
            Utilities.LogIt("The human's age is: " + age + ".\n");
        }
        //Gender Method from the IIdentity interface
        public void Gender(string gender)
        {
            Utilities.LogIt("The human's gender is: " + gender + ".\n");
        }
        //Fly Method from the IFly interface
        public void Fly()
        {
            Utilities.LogIt("The human is flying in an airplane.\n");
        }
        //Overloaded Fly Method from the IFly interface
        public void Fly(int howHigh)
        {
            Utilities.LogIt("The human is flying in an airplane, and it is " + howHigh + " feet high.\n");
        }
        //Swim method from the ISwim interface
        public void Swim()
        {
            Utilities.LogIt("The human is swimming in a lake.\n");
        }
        //Overloaded Swim method from the ISwim interface
        public void Swim(int howDeep)
        {
            Utilities.LogIt("The human is swimming in a lake, and it is swimming " + howDeep + " feet deep.\n");
        }

        public void Move()
        {
            Utilities.LogIt("The human is moving.\n");
        }

        public void Move(int howFast)
        {
            Utilities.LogIt("The human is moving " + howFast + " mph.\n");
        }
    }
}
