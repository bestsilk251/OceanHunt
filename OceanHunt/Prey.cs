using System;
using System.Collections.Generic;
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
            // Create empty Cell in Ocean[this.offSet.X,this.offSet.Y]

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
            throw new NotImplementedException();
        }
        public void MoveFrom(Coordinate from, Coordinate to)
        {
            throw new NotImplementedException();
        }
    }
}