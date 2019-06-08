using System;
using System.Collections.Generic;
namespace diggers_and_fliers
{
    public class AboveGround
    {
        public List<IWalking> walkers { get; set; } = new List<IWalking>();
        public List<ISlithering> slitherers { get; set; } = new List<ISlithering>();
    }
}