using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class AntiHero : SuperHuman
    {
        public string _good { get; set; }

        public AntiHero(string power, int force, int hitPoints, string good) : base(power, force, hitPoints)
        {
            _power = power;
            _force = force;
            _hpoints = hitPoints;
            _good = good;
        }
    }
}
