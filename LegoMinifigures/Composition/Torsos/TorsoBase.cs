using LegoMinifigures.Composition.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{
    abstract class TorsoBase : IColorful
    {
        public abstract bool ChiseledAbs { get; set; }
        public bool Shirted { get; set; }
        public HandType HandType { get; set; }

        public LegoColor Color => throw new NotImplementedException();

        public abstract void Flex();

        public virtual void Breathe()
        {
            Console.WriteLine("Inhale, Exhale...");
        }
    }
}
