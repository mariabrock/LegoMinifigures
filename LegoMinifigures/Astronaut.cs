using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{

    class Astronaut
    {
        public Location Location { get; set; }  //public property
        public bool SuitedUp => Name != "Space Dude";  //an expression bodied property, property will always be true(and readOnly). the expression determines the value of the property
        public string Name { get; }   //readOnly, can only be set within the constructor and not changed anywhere else
        public string Job { get; private set; }  //Public property with private setter. can be gotten whenever, but only set within this class
        public int OxygenLevel { private get; set; }  //only we can get, but anyone can set

        public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob()
        {
            Console.WriteLine($"Doing all my {Job} duties...");
        }
    }
}
