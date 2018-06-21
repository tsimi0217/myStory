using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class Prodigee : SuperHuman
    {
        public string _ppower { get; set; }

        public Prodigee(string power, int force, int hitPoints, string ppower) : base(power, force, hitPoints)
        {
            _power = power;
            _force = force;
            _hpoints = hitPoints;
            _ppower = ppower;
        }

    }
}
