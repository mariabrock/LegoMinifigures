using LegoMinifigures.Composition.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{
    class DadBodTorso : TorsoBase
    {
        public bool IsHairy { get; set; }
        public override bool ChiseledAbs
        {
            get { return false; }
            set { }
        }

        //public LegoColor Color => LegoColor.Yellow;
        //public LegoColor Color{ get; set; }

        public void ChangeTemperature (string weather)
        {
            if (weather == "cold")
            {
                Console.WriteLine("Dad bod turns down the thermostat.");
            }
            else
            {
                Console.WriteLine("Dad bod turns up the thermostat.");
            }
        }

        public override void Flex()
        {
            Console.WriteLine($@"The Dad bod flexes his 
                {(IsHairy ? "Hairy" : "Smooth")} 
                beer belly while using is {HandType} 
                hands to point at his flabby arms ");
        }


    }
}