using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class VirtualPet
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public VirtualPet(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public VirtualPet()
        {

        }
    }
}
