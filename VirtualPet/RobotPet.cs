using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class RobotPet : Pet 

    {
    public int Oil { get; set; }
    public int Boredom { get; set; }
    public int Performance { get; set; }

    public RobotPet() : base("", "")
    {

        Oil = 5;
        Boredom = 6;
        Performance = 7;
    }


    }
}
