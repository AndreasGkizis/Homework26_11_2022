using RouaMatHomework26_11_2022.Interfaces;
using RouaMatHomework26_11_2022.Models;
using System;
using System.Collections.Generic;

namespace RouaMatHomework26_11_2022.Helpers
{
    internal class CreateWorld
    {
        public static void bigBang()
        {
            Console.WriteLine("ONCE UPON A TIME IN A GALAXY FAR FAR AWAY....");
            Console.WriteLine("BOOOOOM!");

            IPlaces park = new Outside();
            List<Person> listOfPeople = createPeople();
            Person john = listOfPeople[0];
            Person ann = listOfPeople[1];

            House spiti = new House(john, "Castle of John the III");

            spiti.listOfRooms[0].peopleInside.Add(john);
            Bell kati2 = House.bell;

            john.currentLocation = spiti;

            ann.goToPlace(spiti);
            //
            ann.interact(spiti, House.bell);
            john.interact(spiti, House.door);

            john.Fuck(ann);

            john.goToPlace(park, ann);

            // enough fucking 
            john.becomeEngaged(ann);

        }

        public static List<Person> createPeople()
        {
            List<Person> listOfPeople = new List<Person>();
            Person person1 = new Person("John", true);
            listOfPeople.Add(person1);
            Person person2 = new Person("Ann", false);
            listOfPeople.Add(person2);
            Console.WriteLine("------------ All people created ------------\n");

            return listOfPeople;
        }


    }
}