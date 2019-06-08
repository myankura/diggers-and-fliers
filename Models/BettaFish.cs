using System;

namespace diggers_and_fliers
{

    public class BettaFish : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("I am confined to this tank, all I can do is swim in circles");
        }

        public int MaximumDepth { get; set; }

    }
}