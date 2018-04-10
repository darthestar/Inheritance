using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    

    class Human : BaseClass, IHumanAnimalStates
    {
        private bool isAsleep = true;
        
        public Human(string name, string birthday, string food)
        {
            this.birthday = birthday;
            this.name = name;
            this.food = food;
            this.greeting = "Hello World";
        }

        public void FallAsleep()
        {
            Console.WriteLine($"{name} says Goodnight");
            isAsleep = true;
        }

        public void WakeUp()
        {
            Console.WriteLine($"{name} says Good morning");
            isAsleep = false;
        }
        public void Eat()
        {
            Console.WriteLine($"{name} is eating {food}");
        }
        
        public void AdoptPet(Pet pet)
        {
             pet.ownerName = name;
            var petList = new List<Pet>();
                petList.Add(pet);
        }

        public void ToString()
        {
            Console.WriteLine("My name is " + name + " and my birthday is on " + birthday);
        }
    }
}
