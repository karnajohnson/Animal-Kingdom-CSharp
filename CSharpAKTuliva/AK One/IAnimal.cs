using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuliva.com.AnimalKingdom.Interfaces
{
    public interface IAnimal: IEat, IReproduce, IIdentity
    {
        void Move();
        void Move(int howFast);
    }
}
