using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Robot :Pet, IRobotStates
    {
        private bool isAsleep;

        public Robot(string versionNumber)
        {
            this.versionNumber = versionNumber;
            this.greeting = "Greetings Earthling";
        }

        public void StartUp()
        {
            isAsleep = false;
        }
        public void ShutDown()
        {
            isAsleep = true;
        }

        public void ToString()
        {
            Console.WriteLine("Robot version is: " + versionNumber);
        }
    }
}