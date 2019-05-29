using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    class RobotPet : Pet 

    {
        public int Oil { get; set; }
        public int Performance { get; set; }

        public RobotPet(int oil, int performance) : base("", "")
        {
            Oil = oil;
            Performance = performance;
        }


    }
}
