using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHero : SuperHuman
    {
        public string _opower { get; set; }

        public SuperHero(string power, int force, int hitPoints, string opower) : base (power, force, hitPoints)
        {
            _power = power;
            _force = force;
            _hpoints = hitPoints;
            _opower = opower;
        }

    }
}
