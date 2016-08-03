using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuliva.com.AnimalKingdom.Hierarchy;
using Tuliva.com.AnimalKingdom.EnumTypes;

namespace Tuliva.com.AnimalKingdom.Interfaces
{
    public interface IIdentity
    {
        void Name(string name);
        void Age(int age);
        void Gender(string gender);
    }
}
