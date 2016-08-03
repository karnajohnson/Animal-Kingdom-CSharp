/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the interfaces in a base class. 
   Class: This is the BaseTrout class.
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
    //public sealed class BaseTrout implementing interfaces
    public sealed class BaseTrout : IEat, IReproduce, IIdentity, ISwim, IAnimal 
    {
        //constructor
        private BaseTrout()
        {
            //printing to the screen that the BaseTrout class has been initialized.
            Utilities.LogIt("This is confirming that the BaseTrout class has been initialized.\n");
        }

        public static BaseTrout getDecoupledTrout()
        {
            return new BaseTrout();
        }
        //Default Eat Method from the IEat interface
        public void Eat()
        {
            Utilities.LogIt("The trout is eating.\n");
        }
        //1st overloaded Eat method from the IEat interface
        public void Eat(string food)
        {
            Utilities.LogIt("The trout is eating " + food + ".\n");
        }
        //2nd overloaded Eat method from the IEat interface
        public void Eat(string food, string how)
        {
            Utilities.LogIt("The trout is eating " + food + " and is using " + how + ".\n");
        }
        //default Reproduce method from the IReproduce interface
        public void Reproduce()
        {
            Utilities.LogIt("The trout is reproducing by laying eggs.\n");
        }
        //Overloaded Reproduce method from the IReproduce interface
        public void Reproduce(int howManyBabies)
        {
            Utilities.LogIt("The trout is reproducing by laying eggs and had " + howManyBabies + " baby(ies).\n");
        }
        //Name Method from the IIdentity interface
        public void Name(string name)
        {
            Utilities.LogIt("The trout's name is: " + name + ".\n");
        }
        //Age method from the IIdentity interface
        public void Age(int age)
        {
            Utilities.LogIt("The trout's age is: " + age + ".\n");
        }
        //Gender method from the IIdentity interface
        public void Gender(string gender)
        {
            Utilities.LogIt("The trout's gender is: " + gender + ".\n");
        }
        //Swim method from the ISwim interface
        public void Swim()
        {
            Utilities.LogIt("The trout is swimming through the water.\n");
        }
        //Overloaded Swim method from the ISwim interface
        public void Swim(int howDeep)
        {
            Utilities.LogIt("The trout is swimming through the water, and it is swimming " + howDeep + " deep.\n");
        }
        public void Move()
        {
            Utilities.LogIt("The trout is moving.\n");
        }

        public void Move(int howFast)
        {
            Utilities.LogIt("The trout is moving " + howFast + " mph.\n");
        }
    }
}
