using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OceanHunt
{
    public abstract class Cell
    {
        public Coordinate OffSet { get; set; }
        public string Image { get; set; }
        public Cell(Coordinate offSet, string image)
        {
            OffSet = offSet;
            Image = image;
        }

    }
}