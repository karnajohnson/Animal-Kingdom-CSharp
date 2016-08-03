/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating collections
   Class: This is the ZooCollection class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuliva.com.AnimalKingdom.Hierarchy;

namespace Tuliva.com.AnimalKingdom.Collections
{
    public class ZooCollection
    {
        //creating an Animal Collection
        private List<Animal> myAnimal;

        //constructor
        public ZooCollection()
        {
            //instantiating the Animal Collection
            myAnimal = new List<Animal>();
        }

        //Add Method
        public void Add(Animal obj)
        {
            //Adding the Animal object into the 
            //collection
            myAnimal.Add(obj);
        }

        //Sort Method
        public void Sort()
        {
            //Sorting the Animal Collection
            myAnimal.Sort();
        }

        //Clear Method
        public void Clear()
        {
            //Clearing the collection
            myAnimal.Clear();
        }

        //Remove Method
        public void Remove(Animal obj)
        {
            //Removing the Animal Object 
            //from the collection
            myAnimal.Remove(obj);
        }

        //Each method demonstrating the foreach loop
        //for the collection
        public void Each()
        {
            //for all Animals in myAnimal
            foreach (Animal a in myAnimal)
            {
                //Animal Eats
                a.Eat();
                //Animal Reproduces
                a.Reproduce();
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
            //casting Human into myAnimal and having it work
            ((Human)(myAnimal[0])).Work();
            //casting Duck into myAnimal and having it swim
            ((Duck)(myAnimal[1])).Swim();
            //casting Trout into myAnimal and having it swim
            ((Trout)(myAnimal[2])).Swim();
        }
    }
}
