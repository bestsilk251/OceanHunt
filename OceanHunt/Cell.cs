using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OceanHunt
{
    public abstract class Cell
    {
        public Coordinate OffSet { get; set; }
        public Cell(Coordinate offSet)
        {
            OffSet = offSet;
        }

    }
}