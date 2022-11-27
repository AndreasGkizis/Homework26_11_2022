using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouaMatHomework26_11_2022.Models
{
    internal class HouseItems: LifelessBaseClass
    {
        public House kapoioSpiti { get; set; }

        public HouseItems()
        {

        }

        public HouseItems(string onoma, House spiti) 
        {
            //House kapoioSpiti = new House();
            kapoioSpiti = spiti;
            Name = onoma;
            if (this.GetType() == typeof(Bell))
            {
                spiti.listOfThings.Add(this);
            }else if (this.GetType() == typeof(Door))
            {
                spiti.listOfDoors.Add((Door)this);
            }else
            {
                spiti.listOfRooms.Add((Room)this);
            }
        }

        public override string ToString()
        {
            return $"HouseItem |-> name - {Name}, kommati ths {kapoioSpiti.Name}";
        }
    }
}
