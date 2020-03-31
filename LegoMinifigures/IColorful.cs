using LegoMinifigures.Composition.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    interface IColorful
    {
        LegoColor Color { get;  }
    }

    interface ILegoPiece : IMoveable, IColorful
    {

    }
}
