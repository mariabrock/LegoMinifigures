using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Heads
{
    class AstronautHead
    {
        public bool Helmeted { get; set; }
        public string FacialExpression { get; set; }
        public LegoColor Color { get; set; }
        public LegoColor EyeColor { get; set; }


        public void Talk ()
        {
            Console.WriteLine($"The {FacialExpression} astronaut says'Tell my wife I love her very much.'");
        }

        public void EatPie(string typeofPie)
        {
            if (typeofPie == "apple")
                Console.WriteLine("MMM...Pie.");
            else
                Console.WriteLine("This is not pie");
        }
    }
}
