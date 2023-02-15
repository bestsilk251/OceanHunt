using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace OceanHunt
{
    public class Ocean
    {

        public static Random random = new Random();

        public static int _numRows = 25;            // число рядків
        public static int _numCols = 70;            // число стовпців
        public static int _size = _numCols * _numRows;
        public static int _numPrey = 150;          // жертви
        public static int _numPredators = 20;      // хижаки
        public static int _numObstacles = 75;      // перешкоди
        public static int _iterationCounter = 1000; // ітерації 


        public static Cell[,] _cells = new Cell[_numRows, _numCols];

        

        public static void Run(int iterationCounter)
        {
            InitCells(_numRows, _numCols);

            AddObstacles();
            AddPreys();
            AddPredators();

            for (int k = 0; k < iterationCounter; k++)  
            {
                for (int i = 0; i < _cells.GetLength(0); i++)
                {
                    for (int j = 0; j < _cells.GetLength(1); j++)
                    {
                        _cells[i, j].Process();
                    }
                }

                DisplayBorders();
                DisplayCells();
                DisplayBorders();

                Thread.Sleep(50);

                Console.Clear();
            }

            

        }
        private static void InitCells(int numRows, int numCols)                // заповнення масиву
        {
            //AddEmptyCell();
            
            Cell[,] newCells = new Cell[numRows, numCols];
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    newCells[i, j] = new Cell(new Coordinate {X = i, Y = j }, Emoji.ImageForCell) ;

                }
            }
            _cells = newCells;
        }

        private static void DisplayCells()                         // принт масиву
        {
            Console.WriteLine();
            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                for (int j = 0; j < _cells.GetLength(1); j++)
                {
                    Console.Write(_cells[i, j].Image);
                }
                Console.WriteLine();
                
            }
        }

        private static void AddPredators()              // хижак
        {
            Coordinate empty;
            for (int i = 0; i < _numPredators; i++)
            {

                empty = GetEmptyCellCoord();
                _cells[empty.X, empty.Y] = new Prey(empty, Emoji.ImageForPredator);

            }
        }
        private static void AddPreys()                  // жертва
        {
            Coordinate empty;
            for (int i = 0; i < _numPrey; i++)
            {

                empty = GetEmptyCellCoord();
                _cells[empty.X, empty.Y] = new Prey(empty, Emoji.ImageForPrey);

            }
        }

        private static void AddObstacles()            // перешкоди
        {
            Coordinate empty;
            for (int i = 0; i < _numObstacles; i++)
            {
                
                empty = GetEmptyCellCoord();
                _cells[empty.X, empty.Y] = new Obstacle(empty, Emoji.ImageForObstacle);
                
            }
        }

        //private static void AddEmptyCell()           // клітки
        //{
        //    for (int i = 0; i < _numRows; i++)
        //    {
        //        for (int j = 0; j < _numCols; j++)
        //        {
        //            _cells[i, j] = null;
        //        }
        //    }
        //}

        public static Coordinate GetEmptyCellCoord()
        {
            //do
            //{
            //    x = random.Next(0, _numCols - 1);
            //    y = random.Next(0, _numRows - 1);
            //} while (_cells[x, y].Image != Emoji.ImageForCell);


            int x = random.Next(0, _numCols - 1);
            int y = random.Next(0, _numRows - 1);

            Coordinate empty = _cells[y, x].OffSet;


            return empty;
        }


        private static void DisplayBorders()         // кордони
        {
            for (int i = 0; i < _numCols; i++)
            {
                Console.Write("*");
            }
        }
    }
}