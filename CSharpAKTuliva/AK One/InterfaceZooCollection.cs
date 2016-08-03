/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the interfaces for a collection. 
   Class: This is the InterfaceZooCollection class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuliva.com.AnimalKingdom.Hierarchy;
using Tuliva.com.AnimalKingdom.Interfaces;
using Tuliva.com.AnimalKingdom.Base;

namespace Tuliva.com.AnimalKingdom.Collections
{
    public class InterfaceZooCollection
    {
        //creating a IAnimal Collection
        private List<IAnimal> myAnimal;

        //constructor
        public InterfaceZooCollection()
        {
            //instantiating the IAnimal Collection
            myAnimal = new List<IAnimal>();
        }

        //Add Method
        public void Add(IAnimal obj)
        {
            //Adding the object to the collection
            myAnimal.Add(obj);
        }

        //sorting method
        public void Sort()
        {
            //sorting the collection
            myAnimal.Sort();
        }

        //clear method
        public void Clear()
        {
            //clearing the collection
            myAnimal.Clear();
        }
        
        //Remove Method
        public void Remove(IAnimal obj)
        {
            //removing the IAnimal object
            myAnimal.Remove(obj);
        }

        //Each method demonstrating the foreach loop
        //for the collection
        public void Each()
        {
            //for all the IAnimals in myAnimal
            foreach (IAnimal a in myAnimal)
            {
                //IAnimal eats
                a.Eat();
                //IAnimal reproduces
                a.Reproduce();
                //IAnimal moves
                a.Move();
            }
        }

        //Count method
        public int Count()
        {
            //declaring a counting variable
            int counting = 0;
            //assigning counting to myAnimal.Count
            counting = myAnimal.Count();
            //returning the counting variable
            return counting;
        }

        //Cast method to demonstrate casting
        public void Cast()
        {
            //casting BaseHuman into myAnimal and having it eat
            ((BaseHuman)(myAnimal[0])).Eat();
            //casting BaseDuck into myAnimal and having it swim
            ((BaseDuck)(myAnimal[1])).Swim();
            //casting BaseTrout into myAnimal and having it swim
            ((BaseTrout)(myAnimal[2])).Swim();
        }
    }
}

