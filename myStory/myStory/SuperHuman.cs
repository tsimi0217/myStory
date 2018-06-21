using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHuman
    {
        public string _power { get; set; }
        public int _force { get; set; }
        public int _hpoints { get; set; }

        public SuperHuman(string power, int force, int hitPoints)
        {
            _power = power;
            _force = force;
            _hpoints = hitPoints;
        }
    }
}
