﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{
    class AstronautTorso
    {
        public int NumberofArms { get; set; }
        public bool ChiseledAbs { get; set; }
        public bool Shirted { get; set; }
        public HandType HandType { get; set; }

        public void Flex()
        {
            if (ChiseledAbs && !Shirted)
            {
                Console.WriteLine("Check out my sick abs!");
            }
            else if (HandType == HandType.XBuster)
            {
                Console.WriteLine("Welcome tot he gunshow.")
            }
            else
            {
                Console.WriteLine("Weird flex, but ok.");
            }
        }
    }

    enum HandType 
    {
        Human,
        Robot,
        Baby,
        Tentacles,
        CanadaArm,
        XBuster
    }

}