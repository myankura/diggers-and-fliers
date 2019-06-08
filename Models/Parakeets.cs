using System;

namespace diggers_and_fliers{

    public class Parakeets : IFlying, IWalking{

        public void Fly()
        {
            Console.WriteLine("I can fly.");
        }

        public void Dive()
        {
            Console.WriteLine("I can dive from the air.");
        }

        public void Glide()
        {
            Console.WriteLine("I can glide when I want to take a break from flapping my wings.");
        }

        public void Walk()
        {
            Console.WriteLine("I can walk.");
        }
        public void Run()
        {
            Console.WriteLine("I can run too, I just think flying is a better way to get around.");
        }
    }
}