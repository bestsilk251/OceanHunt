using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OceanHunt
{
    public class Cell
    {
        public Coordinate OffSet { get; set; }
        public string Image { get; set; }
        public Cell(Coordinate offSet, string image)
        {
            OffSet = offSet;
            Image = image;
        }
        public virtual void Process() { }
        public bool IsCellEmpty(Coordinate coordinate)
        {
            return Ocean._cells[coordinate.X, coordinate.Y].GetType() == typeof(Cell);
        }
        public bool IsCellPrey(Coordinate coordinate)
        {
            return Ocean._cells[coordinate.X, coordinate.Y].GetType() == typeof(Prey);
        }
        public bool IsCellObstacle(Coordinate coordinate)
        {
            return Ocean._cells[coordinate.X, coordinate.Y].GetType() == typeof(Obstacle);
        }
        public Cell GetCellAt(Coordinate coordinate)
        {
            return Ocean._cells[coordinate.X, coordinate.Y];
        }
        public void AssignCellAt(Cell cell, Coordinate coordinate)
        {
            Ocean._cells[coordinate.X, coordinate.Y] = cell;
        }
        public Cell GetCellFromEast()
        {
            return Ocean._cells[this.OffSet.X, this.OffSet.Y + 1];
        }
        public Cell GetCellFromWest()
        {
            return Ocean._cells[this.OffSet.X, this.OffSet.Y - 1];
        }
        public Cell GetCellFromNorth()
        {
            return Ocean._cells[this.OffSet.X - 1, this.OffSet.Y];
        }
        public Cell GetCellFromSouth()
        {
            return Ocean._cells[this.OffSet.X + 1, this.OffSet.Y];
        }
    }
}