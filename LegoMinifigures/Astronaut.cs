using System;
using System.Collections.Generic;
using System.Text;
using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torsos;

namespace LegoMinifigures
{

    class Astronaut
    {
        public Location Location { get; set; }  //public property
        public bool SuitedUp => Name != "Space Dude";  //an expression bodied property, property will always be true(and readOnly). the expression determines the value of the property
        public string Name { get; }   //readOnly, can only be set within the constructor and not changed anywhere else
        public string Job { get; private set; }  //Public property with private setter. can be gotten whenever, but only set within this class
        public int OxygenLevel { private get; set; }  //only we can get, but anyone can set

        public AstronautTorso Torso { get; set; }
        public AstronautLegs Legs { get; set; }
        public AstronautHead Head { get; set; }


        public Astronaut(string name, string job, AstronautHead head, AstronautTorso torso, AstronautLegs legs)
        {
            Name = name;
            Job = job;

            Head = head;
            Torso = torso;
            Legs = legs;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob(int stepsToWalk)
        {
            Console.WriteLine($"Doing all my {Job} duties...");
            Legs.Walk(stepsToWalk);
            Head.EatPie("Cherry");
            Torso.Flex();
            Legs.Walk(stepsToWalk);
        }
    }
}
