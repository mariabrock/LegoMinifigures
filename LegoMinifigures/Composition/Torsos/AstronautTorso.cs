using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{
    class AstronautTorso : TorsoBase
    {
        public int NumberofArms { get; set; }
        public override bool ChiseledAbs { get; set; }

        public override void Flex()
        {
            if (ChiseledAbs && !Shirted)
            {
                Console.WriteLine("Check out my sick abs!");
            }
            else if (HandType == HandType.XBuster)
            {
                Console.WriteLine("Welcome tot he gunshow.");
            }
            else
            {
                Console.WriteLine("Weird flex, but ok.");
            }
        }

        public override void Breathe()
        {
            Console.WriteLine("Exhale, Inhale...");
        }
    }

}
