using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace OceanHunt
{
    public class Prey : Cell
    {
        public int TimeToReproduce { get; set; }

        public delegate bool Predicate();

        public Prey(Coordinate offSet, string image) : base(offSet, image)
        {
            TimeToReproduce = 6;
        }

        public void Die()
        {
            Ocean._cells[this.OffSet.X, this.OffSet.Y] = new Cell(OffSet, Emoji.ImageForCell);
            if (this.GetType() == typeof(Predator))
            {
                Ocean._numPredators--;
            }
            if (this.GetType() == typeof(Prey))
            {
                Ocean._numPrey--;
            }
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
            int x = OffSet.X;
            int y = OffSet.Y;
            if (TryMove())
            {
                if (TimeToReproduce == 0)
                {
                    Reproduce(new Coordinate() { X = x, Y = y });
                }
            }
        }

        public virtual bool TryMove()
        {
            int lastColumnElement = Ocean._numCols - 1;
            int lastRowElement = Ocean._numRows - 1;
            /*
            Ячейки, примыкающие к краю океана, перемещаются влево-вправо или вниз-вверх.
             Prey:  если возможно, к смежной пустой Cell или остаются на месте.
             Predator: едят случайную соседнюю добычу, или случайным образом двигаются к смежной пустой Cell, или остаются на месте
             */
            if (this.OffSet.X == 0 && (this.OffSet.Y > 0 && this.OffSet.Y < lastColumnElement))
            {
                // move everywhere except north
                return Movements(South, West, East);
            }
            if (this.OffSet.X == 0 && this.OffSet.Y == 0)
            {
                // move except noth and west
                return Movements(South, East);
            }
            if (this.OffSet.X == 0 && this.OffSet.Y == lastColumnElement)
            {
                // move except noth and east
                return Movements(South, West);
            }
            if (this.OffSet.Y == 0 && (this.OffSet.X > 0 && this.OffSet.X < lastRowElement))
            {
                //move everwhere except west
                return Movements(South, North, East);
            }
            if (this.OffSet.X == lastRowElement && (this.OffSet.Y > 0 && this.OffSet.Y < lastColumnElement))
            {
                // move everywhere except south
                return Movements(North, West, East);
            }
            if (this.OffSet.X == lastRowElement && this.OffSet.Y == 0)
            {
                // move except south and west
                return Movements(North, East);
            }
            if (this.OffSet.X == lastRowElement && this.OffSet.Y == lastColumnElement)
            {
                // move except south and east
                return Movements(North, West);
            }
            if (this.OffSet.Y == lastRowElement && (this.OffSet.X > 0 && this.OffSet.X < lastRowElement))
            {
                //move everwhere except east
                return Movements(North, West, South);
            }
            else
            {
                return Movements(North, South, East, West);
            }
        }

        public bool East()
        {
            return IsMove(GetCellFromEast());
        }
        public bool West()
        {
            return IsMove(GetCellFromWest());
        }

        public bool North()
        {
            return IsMove(GetCellFromNorth());
        }
        public bool South()
        {
            return IsMove(GetCellFromSouth());
        }

        public virtual bool IsMove(Cell cellFrom)
        {
            // логіка чи йому рухатись чи залишатись на місці ( враховуються всі приорітети руху)
            if (IsCellEmpty(cellFrom.OffSet))
            {
                MoveCellTo(cellFrom.OffSet);
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool Movements(params Predicate[] methods)
        {
            // перебирає всі можливі рухи для клітинки в залежноісті він її положення в масиві
            //і якщо рух поверне позитивне значення, ми завершимо
            // метод та клітинка виконає свій рух, якщо ні один метод не поверне true, клітинка залишиться на місці
            foreach (var method in methods)
            {
                if (method.Invoke())
                {
                    return true;
                }
            }
            return false;
        }
        public void Reproduce(Coordinate coordinate)
        {
            Ocean._cells[coordinate.X, coordinate.Y] = new Prey(coordinate, this.Image);
            if (this.GetType() == typeof(Predator))
            {
                Ocean._numPredators++;
            }
            if (this.GetType() == typeof(Prey))
            {
                Ocean._numPrey++;
            }
        }
        public void MoveCellTo(Coordinate to)
        {
            int x = this.OffSet.X;
            int y = this.OffSet.Y;
            Ocean._cells[x, y] = new Cell(OffSet, Emoji.ImageForCell);
            this.OffSet = to;
            AssignCellAt(this, to);
        }
    }
}