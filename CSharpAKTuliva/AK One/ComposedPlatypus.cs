/*
   Name of Programmer: Karna Johnson
   Company: Tuliva.com
   Project: Animal Kingdom
   Description: Demonstrating the animal hierarchy. 
   Class: This is the ComposedPlatypus class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuliva.com.AK.Utilities;

namespace Tuliva.com.AnimalKingdom.Hierarchy
{
    public sealed class ComposedPlatypus
    {
        //private fields
        private Duck m_DuckPart = null;
        private Trout m_TroutPart = null;
        
        //Property for Duck
        public Duck DuckPART
        {
            get
            {
                return this.m_DuckPart;
            }
        }

        //Property for Trout
        public Trout TroutPART
        {
            get
            {
                return this.m_TroutPart;
            }
        }

        //constructor
        public ComposedPlatypus()
        {
            this.m_DuckPart = new Duck();
            this.m_TroutPart = new Trout();


            Utilities.LogIt("This is to confirm that the Platypus class has been initialized.\n");
        }

        //Unique Nurse method | Printing to the screen that the platypus is nursing in its unique way
        public void Nurse()
        {
            Utilities.LogIt("The platypus is nursing with its sticky milk\nwith the playtpi stuck to the mother.\n");
        }

        //LayEggs Method | Using the method from the Bird class.
        public void LayEggs()
        {
            m_DuckPart.LayEggs();
        }

        //SwimLikeFish method | Using the method from Trout class.
        public void SwimLikeFish()
        {
            m_TroutPart.Swim();
        }

        //SwimLikeDuck method | Using the method from Duck class.
        public void SwimLikeDuck()
        {
            m_DuckPart.Swim();
        }
    }
}
