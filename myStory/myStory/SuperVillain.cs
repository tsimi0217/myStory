using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperVillain : SuperHuman
    {
        public string _evil { get; set; }

        public SuperVillain(string power, int force, int hitPoints, string evil) : base(power, force, hitPoints)
        {
            _power = power;
            _force = force;
            _hpoints = hitPoints;
            _evil = evil;
        }
    }
}
