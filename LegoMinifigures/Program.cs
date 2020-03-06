using System;
using LegoMinifigures.Gals;
using LegoMinifigures.Guys;


namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var waveHello = new Glee();
            waveHello.IsALady = true;

            var hangloose = new WaveRider();
            hangloose.notALady = true;

            var gardening = new Leah();
            gardening.canBuild = true;

            var totally = new Dude();
            totally.notALady = true;
        }
    }
}
