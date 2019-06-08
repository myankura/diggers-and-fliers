using System;

namespace diggers_and_fliers
{

    public class Terrapins : IWalking, ISwimming
    {

        public void Swim()
        {
            Console.WriteLine("I'm a turtle and I can swim.");
        }
        public int MaximumDepth { get; set; }

        public void Walk()
        {
            Console.WriteLine("I can walk too.");
        }

        public void Run()
        {
            Console.WriteLine("I can't quite run, but I can still dream.");
        }
    }
}