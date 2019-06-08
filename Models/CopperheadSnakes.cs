using System;

namespace diggers_and_fliers
{

    public class CopperheadSnakes : ISlithering, ISwimming
    {
        public void Slither()
        {
            Console.WriteLine("I slither across the ground. No step on Snek!");
        }

        public void MoveFast()
        {
            Console.WriteLine("I can move quickly and I'm venemous, I am Snek.");
        }

        public void Swim()
        {
            Console.WriteLine("Snek can swim too.");
        }

        public int MaximumDepth { get; set; }

    }
}