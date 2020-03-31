using System;
using System.Collections.Generic;
using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torsos;


namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new AstronautHead
            {
                FacialExpression = "Smiling",
                Color = LegoColor.Orange,
                EyeColor = LegoColor.Green,
                Helmeted = true
            };

            var legs = new AstronautLegs
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops
            };

            var dtorso = new DadBodTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                Shirted = true
            };

            var atorso = new AstronautTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                NumberofArms = 3,
                Shirted = true

            };

            atorso.Breathe();
            dtorso.Breathe();
            atorso.HandType = HandType.Baby;
            dtorso.ChiseledAbs = false;

            var astronaut = new Astronaut("Space Dude", "Janitor", head, torso, legs);
            var astronaut2 = new Astronaut("Space Lady", "Janitor", head, torso, legs);

            astronaut.DoYourJob(55);

            var casper = new Ghost("Casper", DateTime.Today);
            casper.Friendly = true;
            //OR
            //{
            //    Friendly = true;
            //}
            casper.Spook();
            casper.Haunt("Whipstaff Manor");
            casper.Spook();

            var fatso = new Ghost("Fatso", new DateTime(1924, 12, 1));
            fatso.Friendly = false;

            fatso.Spook();
            fatso.Haunt("Your House");
            fatso.Spook();

            var torsos = new List<TorsoBase> { dtorso, atorso, new DadBodTorso()};

            foreach (var torso in torsos)
            {
                torso.Breathe();
                torso.Flex();
            }

            var colorfulThings = new List<IColorful> { dtorso, new BabyLegs() };

            foreach (var colorfulThing in colorfulThings)
            {
                Console.WriteLine(colorfulThing.Color);
            }

            Console.ReadKey();
        }
    }
}
