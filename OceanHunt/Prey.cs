using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OceanHunt
{
    public class Prey : Cell
    {
        public int TimeToReproduce { get; set; }

        public Prey(Coordinate offSet, string image) : base(offSet, image)
        {
            TimeToReproduce = 6;
        }

        public void Die()
        {
            Ocean._cells[this.OffSet.X, this.OffSet.Y] = new Cell(OffSet, Emoji.ImageForCell);
            Clear();
        }

        private void Clear()
        {
            this.OffSet = null;
            this.Image = null;
            this.TimeToReproduce = 0;
        }

        public override void Process()
        {
            base.Process();

            TimeToReproduce--;

        }

        //public Cell GetEmptyNeighbor()
        //{
        //    throw new NotImplementedException();
        //}
        //public Cell GetPreyNeighbor()
        //{
        //    throw new NotImplementedException();
        //}

        public void Reproduce(Coordinate coordinate)
        {
            Ocean._cells[coordinate.X, coordinate.Y] = new Prey(coordinate, this.Image);
        }
        public void MoveFrom(Coordinate from, Coordinate to)
        {
            if (TimeToReproduce == 0)
            {
                Reproduce(from);
            }
            else
            {
                Ocean._cells[from.X, from.Y] = new Cell(from, Emoji.ImageForCell);
            }
            Ocean._cells[to.X, to.Y] = this;
        }
    }
}