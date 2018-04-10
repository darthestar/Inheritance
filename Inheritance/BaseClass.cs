using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BaseClass
    {
        public string versionNumber { get; set; }
        public string food { get; set; }
        public string greeting { get; set; }
        public string birthday { get; set; }
        public string name { get; set; }

        public void SayHello()

        {
            if (versionNumber != null)
            {
                Console.WriteLine($"{this.versionNumber} says {this.greeting}");
            }
            else
                Console.WriteLine($"{this.name} says {this.greeting}");
        }
    }
}
