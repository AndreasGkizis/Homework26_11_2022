using RouaMatHomework26_11_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouaMatHomework26_11_2022.Interfaces
{
    internal interface IPerson
    {
        void Fuck(Person name);
        void becomeEngaged(Person name);
        void goToPlace(IPlaces place, Person person1 = null );
        void interact(House spiti, LifelessBaseClass item);
    }
}
