using System;

namespace diggers_and_fliers
{

    public class Mice : IWalking, IDigging
    {

        public void Dig()
        {
            Console.WriteLine("I am digging a hole now.");
        }
        public void Walk()
        {
            Console.WriteLine("I can walk too.");
        }
        public void Run()
        {
            Console.WriteLine("I can move pretty quick when I want to.");
        }
    }
}