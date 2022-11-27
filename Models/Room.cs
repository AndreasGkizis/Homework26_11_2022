using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouaMatHomework26_11_2022.Models
{
    internal class Room: HouseItems
    {
        public List<Person> peopleInside { get; set; } = new List<Person>();
        public Room()
        {
            Name = "default Name";
            kapoioSpiti = new House();
        }
        public Room(string onoma, House spiti) : base(onoma, spiti)
        {
            //spiti.listOfDoors.Add(this);
        }

        public void activateDoor()
        {
            Console.WriteLine($"!~~~ The {Name} has been OPENED ~~~! ");
        }

        public override string ToString()
        {
            return $"Room {Name}";
        }
    }
}
