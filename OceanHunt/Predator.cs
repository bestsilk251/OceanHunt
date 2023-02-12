using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OceanHunt
{
    public class Predator : Prey
    {
        public Predator(Coordinate offSet, string image) : base(offSet, image)
        {
        }
    }
}