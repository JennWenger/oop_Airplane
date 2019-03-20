using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    enum AircraftType
    {
        FixedWing, RotaryWing, LighterThanAir
    }
    internal class Aircraft
    {
        public string Name { get; set; }
        public AircraftType Type { get; internal set;}
    }
}
