using System;
using System.Collections.Generic;

namespace diggers_and_fliers
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of each animal class
            Ants ant = new Ants();
            BettaFish betta = new BettaFish
            {
                MaximumDepth = 1
            };
            CopperheadSnakes copperhead = new CopperheadSnakes
            {
                MaximumDepth = 6
            };
            Earthworms worm = new Earthworms();
            Finches finch = new Finches();
            Gerbils gerbil = new Gerbils();
            Mice mice = new Mice();
            Parakeets parakeet = new Parakeets();
            Terrapins terrapin = new Terrapins
            {
                MaximumDepth = 12
            };
            TimberRattlesnakes timber = new TimberRattlesnakes
            {
                MaximumDepth = 6
            };

            //add the animals to their respective container
            Diggers diggersContainer = new Diggers();
            diggersContainer.diggers.Add(ant);
            diggersContainer.diggers.Add(worm);
            diggersContainer.diggers.Add(gerbil);
            diggersContainer.diggers.Add(mice);

            Swimmers swimmersContainer = new Swimmers();
            swimmersContainer.swimmers.Add(betta);
            swimmersContainer.swimmers.Add(copperhead);
            swimmersContainer.swimmers.Add(terrapin);
            swimmersContainer.swimmers.Add(timber);

            Fliers fliersContainer = new Fliers();
            fliersContainer.fliers.Add(finch);
            fliersContainer.fliers.Add(parakeet);

            AboveGround aboveGroundContainer = new AboveGround();
            aboveGroundContainer.walkers.Add(ant);
            aboveGroundContainer.walkers.Add(gerbil);
            aboveGroundContainer.walkers.Add(mice);
            aboveGroundContainer.walkers.Add(terrapin);
            aboveGroundContainer.walkers.Add(finch);
            aboveGroundContainer.walkers.Add(parakeet);
            aboveGroundContainer.slitherers.Add(copperhead);
            aboveGroundContainer.slitherers.Add(timber);
        }
    }
}
