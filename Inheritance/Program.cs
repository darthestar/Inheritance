using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human("Hildagard", "August 1, 2000", "Burgers");
            var panda = new Panda("Holly", "January 15, 2012", "Bamboo");
            var robot = new Robot("V900");

            human.FallAsleep();
            human.WakeUp();
            human.SayHello();
            human.Eat();
            human.AdoptPet(robot);
            human.AdoptPet(panda);
            Console.WriteLine($"{human.name} adopted {panda.name} the panda");
            Console.WriteLine($"{human.name} adopted {robot.versionNumber} the robot");

            human.ToString();

            panda.FallAsleep();
            panda.WakeUp();
            panda.SayHello();
            panda.Eat();
            Console.WriteLine($"The panda named {panda.name} is owned by {panda.ownerName}");
            
            robot.ToString();
            robot.StartUp();
            robot.ShutDown();
            robot.SayHello();

            robot.ToString();

            var baseClass = new List<BaseClass>();
            baseClass.Add(new Human("Delila", "June 24, 1998", "Chicken Fingers"));
            baseClass.Add(new Panda("Alice", "September 24, 1996", "Chicken Fingers"));
            baseClass.Add(new Robot("D-777"));
            foreach(var baseclass in baseClass)
            {
                baseclass.SayHello();
            }

            Console.ReadLine();
        }
    }
}
