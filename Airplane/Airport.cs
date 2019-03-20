using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    [Flags]
    enum AirportAmenities
    {
        FastFood = 1,
        FineDining = 2,
        FreeWifi = 4,
        Shopping = 8
    }

    internal class Airport
    {
        public string Name { get; internal set; }
        public AirportAmenities Amenities { get; internal set; }
    }
}
