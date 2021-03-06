﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft ac = new Aircraft()
            {
                Name = "P-51",
                Type = AircraftType.FixedWing,
            };
            Console.WriteLine("The {0} is a {1} aircraft.", ac.Name, ac.Type);

            Airport ap = new Airport()
            {
                Name = "RDU",
                Amenities = AirportAmenities.FastFood |
                AirportAmenities.FineDining |
                AirportAmenities.FreeWifi |
                AirportAmenities.Shopping,
            };
            Console.WriteLine("{0} has the following: {1}", ap.Name, ap.Amenities);
        }
        
    } 
    }

