using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace OceanHunt
{
    public class Ocean
    {

        public Random random = new Random();

        public static int _numRows = 25;            // число рядків
        public static int _numCols = 70;            // число стовпців
        public static int _size = _numCols * _numRows;
        public static int _numPrey = 150;          // жертви
        public static int _numPredators = 20;      // хижаки
        public static int _numObstacles = 75;      // перешкоди
        public static int _iterationCounter = 1000; // ітерації 


        public static Cell[,] _cells = new Cell[_numRows, _numCols];

        #region fastback
        //static int numRows = 25;            // число рядків
        //static int numCols = 70;            // число стовпців
        //static int size = numCols * numRows;
        //static int numPrey = 150;          // жертви
        //static int numPredators = 20;      // хижаки
        //static int numObstacles = 75;      // перешкоди
        //static int interationCounter = 1000; // ітерації 

        //public static Cell[,] Cells = new Cell[,] { };
        //public static void GettingInfo()
        //{
        //    Run(interationCounter);
        //    interationCounter = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"Enter number of rows DEFAULT = {numRows}");
        //    numRows = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"Enter number of columns DEFAULT = {numCols}");
        //    numCols = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"Enter number of preys DEFAULT = {numPrey}");
        //    numPrey = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"Enter number of predators DEFAULT = {numPredators}");
        //    numPredators = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"Enter number of obstacles DEFAULT = {numObstacles}");
        //    numObstacles = int.Parse(Console.ReadLine());
        //    Console.WriteLine("");
        //    Console.WriteLine($"Number of interations: {interationCounter}");
        //    Console.WriteLine($"Your size is: {numRows * numCols}");
        //    Console.WriteLine($"Number of rows: {numRows}");
        //    Console.WriteLine($"Number of columns: {numCols}");
        //    Console.WriteLine($"Number of preys: {numPrey}");
        //    Console.WriteLine($"Number of predators: {numPredators}");
        //    Console.WriteLine($"Number of obstacles: {numObstacles}");

        //    Cells = InitCells(numRows, numCols);

        //    //DisplayBorder(numRows);
        //    //DisplayBorder(cells);
        //    DisplayCells(Cells);
        //    //DisplayBorder(numRows);
        //}
        #endregion




        public void Run(int iterationCounter)
        {

            Console.WriteLine($"Enter the number of interations DEFAULT = {iterationCounter}");
            AddObstacles();
            InitCells(_numRows, _numCols);
            DisplayBorders();
            DisplayCells();
            DisplayBorders();

        }
        private void InitCells(int numRows, int numCols)                // заповнення масиву
        {
            AddEmptyCell();
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

        private void DisplayCells()                         // принт масиву
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

        private void AddPredators()              // хижак
        {

        }
        private void AddPreys()                  // жертва
        {

        }
        private void AddObstacles()            // перешкоди
        {
            Coordinate empty;
            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    empty = GetEmptyCellCoord();
                    _cells[empty.X, empty.Y] = new Obstacle(empty, Emoji.ImageForObstacle);
                }
            }
        }
        private void AddEmptyCell()           // клітки
        {
            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    _cells[i, j] = null;
                }
            }
        }

        Coordinate GetEmptyCellCoord()
        {
            int x;
            int y;
            Coordinate empty;

            x = random.Next(0, _numCols - 1);
            y = random.Next(0, _numRows - 1);

            empty = _cells[x, y].OffSet;


            return empty;
        }


        private void DisplayBorders()         // кордони
        {
            for (int i = 0; i < _numCols; i++)
            {
                Console.Write("*");
            }
        }
    }
}