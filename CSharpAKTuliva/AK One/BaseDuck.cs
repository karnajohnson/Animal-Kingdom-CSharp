/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the interfaces in a base class. 
   Class: This is the BaseDuck class.
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
    //public sealed class BaseDuck implementing interfaces
    public sealed class BaseDuck : IEat, IReproduce, IIdentity, IFly, ISwim, IAnimal
    {
        //constructor
        private BaseDuck()
        {
            Utilities.LogIt("This is confirming that the BaseDuck class has been initialized.\n");
        }

        public static BaseDuck getDecoupledDuck()
        {
            return new BaseDuck();
        }
        //Default Eat Method from the IEat interface
        public void Eat()
        {
            Utilities.LogIt("The duck is eating.\n");
        }
        //1st Eat Method from the IEat interface
        public void Eat(string food)
        {
            Utilities.LogIt("The duck is eating " + food + ".\n");
        }
        //2nd Eat Method from the IEat interface
        public void Eat(string food, string how)
        {
            Utilities.LogIt("The duck is eating " + food + " and is using " + how + ".\n");
        }
        //default Reproduce method from the IReproduce interface
        public void Reproduce()
        {
            Utilities.LogIt("The duck is reproducing.\n");
        }
        //overloaded Reproduce method from the IReproduce interface
        public void Reproduce(int howManyBabies)
        {
            Utilities.LogIt("The duck is reproducing and had " + howManyBabies + " baby(ies).\n");
        }
        //Name Method from the IIdentity interface
        public void Name(string name)
        {
            Utilities.LogIt("The duck's name is: " + name + ".\n");
        }
        //Age Method from the IIdentity interface
        public void Age(int age)
        {
            Utilities.LogIt("The duck's age is: " + age + ".\n");
        }
        //Gender Method from the IIdentity interface
        public void Gender(string gender)
        {
            Utilities.LogIt("The duck's gender is: " + gender + ".\n");
        }
        //Fly Method from the IFly interface
        public void Fly()
        {
            Utilities.LogIt("The duck is flying in the air.\n");
        }
        //Overloaded Fly Method from the IFly interface
        public void Fly(int howHigh)
        {
            Utilities.LogIt("The duck is flying in the air, and it is " + howHigh + " high.\n");
        }
        //Swim Method from the ISwim interface
        public void Swim()
        {
            Utilities.LogIt("The duck is swimming on the surface of the water.\n");
        }
        //Overloaded Swim Method from the ISwim interface
        public void Swim(int howDeep)
        {
            Utilities.LogIt("The duck is swimming on the surface\nof the water, and it is swimming " + howDeep + " deep.\n");
        }
        public void Move()
        {
            Utilities.LogIt("The duck is moving.\n");
        }

        public void Move(int howFast)
        {
            Utilities.LogIt("The duck is moving " + howFast + " mph.\n");
        }
    }
}
