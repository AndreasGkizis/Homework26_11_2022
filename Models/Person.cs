using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using RouaMatHomework26_11_2022.Interfaces;
using RouaMatHomework26_11_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouaMatHomework26_11_2022
{
    internal class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsMale { get; set; }
        public List<Person> Mate { get; set; } = new List<Person>();
        public List<LifelessBaseClass> ListOfThingsOwned { get; set; } = new List<LifelessBaseClass>();
        public IPlaces currentLocation { get; set; }

        public Person()
        {
            FirstName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName()).Generate();
            LastName = RandomizerFactory.GetRandomizer(new FieldOptionsLastName()).Generate();
        }

        public Person(string name, bool gender)
        {
            FirstName = name;
            LastName = RandomizerFactory.GetRandomizer(new FieldOptionsLastName()).Generate();
            IsMale = gender;
            Console.WriteLine($"{this.FirstName} has been born");
        }
        public Person(string name, string lastname)
        {
            FirstName = name;
            LastName = lastname;
            Mate = new List<Person>();
            ListOfThingsOwned = new List<LifelessBaseClass>();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Person is -> {FirstName}");
            //str.AppendLine($"Fullname -> {FirstName} {LastName}");
            //str.AppendLine($"Is male? -> {IsMale}");
            //Mate.ForEach(someone => str.AppendLine($"mate is {someone.FirstName.ToString()})"));
            //ListOfThingsOwned.ForEach(thing => str.AppendLine($"Thing owned {thing.Name.ToString()})"));

            return str.ToString();
        }

        public void Fuck(Person name)
        {
            Console.WriteLine($"\n{this.FirstName} is looking at {name.FirstName} in a funny way...... ;)");
            Console.WriteLine($"{this.FirstName} has just F***ED {name.FirstName}\n");
        }

        public void becomeEngaged(Person name)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~");
            Console.WriteLine($"{this.FirstName} asked {name.FirstName} to become engaged !");
            this.Mate.Add(name);
            name.Mate.Add(this);

            Console.WriteLine("~~~~~~~~~ <3 ~~~~~~~~~");
            Console.WriteLine($"The mate of {this.FirstName} is now {name.FirstName}");
            Console.WriteLine($"And the mate of {name.FirstName} is now {this.FirstName}");
            Console.WriteLine("~~~~~~~~~ <3 ~~~~~~~~~");
        }

        public void goToPlace(IPlaces place, Person person1 = null)
        {
            if ( this.currentLocation!= null )
            {
                //currentLocation
            }
            this.currentLocation = place;
            Console.WriteLine($"{this.FirstName} is going for a walk to the {this.currentLocation.Name}");
            if ( person1 != null )
            {
            person1.currentLocation = place;
                Console.WriteLine( $"with {person1.FirstName}!");
            }
        }

        public void interact(House spiti, LifelessBaseClass item)
        {

            //LifelessBaseClass thing = new LifelessBaseClass();
            if (item.GetType() == typeof(Bell))
            {

                foreach (var thing in spiti.listOfThings)
                {
                    Console.WriteLine($"{this.FirstName} is Ringing the bell ....");
                    Bell bell = (Bell)thing;
                    bell.Ring();
                }
            }
            else if (item.GetType() == typeof(Door))
            {
                foreach (var thing in spiti.listOfDoors)
                {
                    Console.WriteLine($"{this.FirstName} is going for the {thing.Name}");
                    Door porta = (Door)thing;
                    porta.activateDoor();

                }
            }
        }
    }
}
