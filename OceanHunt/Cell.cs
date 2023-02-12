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
        public virtual void Process(){}
        public void IsCellEmpty(Coordinate coordinate)
        {

        }
        public void IsCellPrey(Coordinate coordinate)
        {

        }
        public void IsCellObstacle(Coordinate coordinate)
        {

        }
        public Cell GetCellAt(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }
        public void AssignCellAt(Cell cell, Coordinate coordinate)
        {
        }
        public Cell GetCellFromEast()
        {
            throw new NotImplementedException();
        }
        public Cell GetCellFromWest()
        {
            throw new NotImplementedException();
        }
        public Cell GetCellFromNorth()
        {
            throw new NotImplementedException();
        }
        public Cell GetCellFromSouth()
        {
            throw new NotImplementedException();
        }
    }
}