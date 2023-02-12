using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OceanHunt
{
    public class Obstacle : Cell
    {
        public Obstacle(Coordinate offSet, string image) : base(offSet, image)
        {
        }
    }
}