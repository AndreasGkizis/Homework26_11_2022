using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using RouaMatHomework26_11_2022.Interfaces;

namespace RouaMatHomework26_11_2022.Models
{
    internal class House: LifelessBaseClass , IPlaces
    {
        public Person Owner { get; set; }
        public List<Door> listOfDoors { get; set; } = new List<Door>();
        public List<Room> listOfRooms { get; set; } = new List<Room>();
        public List<LifelessBaseClass> listOfThings { get; set; } = new List<LifelessBaseClass>();
        public static Bell bell = new Bell();
        public static Door door = new Door();

        public House()
        {

        }
        public House(Person owner,string name)
        {
            //listOfThings 
            Owner = owner;
            this.Name = name;
            HouseItems domatio = new Room("living Room", this);

            HouseItems koudouni = new Bell("Super door Bell", this);
            HouseItems porta = new Door("Great Entrance", this);
            Console.WriteLine($"{this.Name} belongs to {Owner.FirstName} and has finished construction(at last...took ages!)");
            Console.WriteLine();

        }
        public Bell GetBell()
        {
            return bell;
        }

        public override string ToString()
        {
            return $"the owner of {Name} is {Owner.FirstName}. "; //And {Owner.FirstName} is in {Owner.currentLocation}
        }

    }
}
