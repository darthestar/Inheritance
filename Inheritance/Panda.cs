using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Panda:Pet, IHumanAnimalStates
    {
        private bool isAsleep = true;


        public Panda(string name, string birthday, string food)
        {
            this.birthday = birthday;
            this.name = name;
            this.food = food;
            this.greeting = "Grrrrrrrrg";


        }

        public void FallAsleep()
        {
            isAsleep = true;
        }

        public void WakeUp()
        {
            isAsleep = false;
        }
        public void Eat()
        {
            Console.WriteLine($"{name} is eating {food}");
        }
        
        public void ToString()
        {
            Console.WriteLine("My name is " + name + " the panda and my birthday is on " + birthday);

        }
    }
}
