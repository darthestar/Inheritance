using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Pet:BaseClass
    {
        public string ownerName{ get; set;}
        public string petname { get; set; }

        public Pet() { 
        
            this.petname = name;
            this.ownerName = ownerName;
        }
        public override string ToString()
        {
            return "Pet owner: " + ownerName;
        }

    }}
