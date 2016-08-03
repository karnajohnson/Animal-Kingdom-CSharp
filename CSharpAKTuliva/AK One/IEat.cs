using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuliva.com.AnimalKingdom.Interfaces
{
    public interface IEat
    {
        void Eat();
        void Eat(string food);
        void Eat(string food, string how);
    }
}
