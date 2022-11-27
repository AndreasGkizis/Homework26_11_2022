using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouaMatHomework26_11_2022.Models
{
    internal class Door: HouseItems
    {
        public bool IsOpen { get; set; } = false;

        public Door()
        {
            Name = "default Name";
            kapoioSpiti = new House();
        }
        public Door(string onoma, House spiti) : base(onoma, spiti)
        {
            //spiti.listOfDoors.Add(this);
        }

        public void activateDoor()
        {
            if (IsOpen == false)
            {
                IsOpen =true;
                Console.WriteLine($"the {Name} has been opened ");

            }
            else
            {
                IsOpen = false;
                Console.WriteLine($"the {Name} has been Closed ");
            }
        }
    }
}
