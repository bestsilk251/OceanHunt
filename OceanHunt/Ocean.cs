using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OceanHunt
{
    public class Ocean
    {

        static Random random = new Random();

        public static int numRows = 25;            // число рядків
        public static int numCols = 70;            // число стовпців
        public static int size = numCols * numRows;
        public static int numPrey = 150;          // жертви
        public static int numPredators = 20;      // хижаки
        public static int numObstacles = 75;      // перешкоди
        public static int interationCounter = 1000; // ітерації 


        public static Cell[,] Cells = new Cell[numRows, numCols];

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




        public static int Run(int iterationCounter)
        {
            Console.WriteLine($"Enter the number of interations DEFAULT = {iterationCounter}");
            return interationCounter;
        }

        //public static void DisplayBorder(int[,] cells)                      // горизонтальні лінії зверху та знизу 
        //{


        //    for (int i = 0; i < cells.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < cells.GetLength(1); j++)
        //        {
        //            if (i == 0 || i == cells.GetLength(0) - 1 || j == 0 || j == cells.GetLength(1) - 1)
        //            {
        //                Console.Write("#");
        //            }
        //            else
        //            {
        //                Console.WriteLine(cells[i, j]);
        //            }

        //        }
        //        Console.WriteLine();
        //    }

        //    //for (int i = 0; i < numRows; i++)
        //    //{
        //    //    Console.Write("#");
        //    //    //continue;
        //    //}

        //}

        //public static void InitCells()
        public static void InitCells(int numRows, int numCols)                // заповнення масиву
        {
            Cell[,] newCells = new Cell[numRows, numCols];
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    newCells[i, j] = new Cell(new Coordinate {X = i, Y = j }, Emoji.ImageForCell) ;

                }
            }
            Cells = newCells;
        }

        //Console.Write("{0, 5}", cells[i, j]);
        public static void DisplayCells()                         // принт масиву
        {
            Console.WriteLine();
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for (int j = 0; j < Cells.GetLength(1); j++)
                {
                    Console.Write(Cells[i, j].Image);
                }
                Console.WriteLine();
                
            }
        }

        public static void AddPredators()
        {

        }

        //public static void DisplayBorders()
        //{

        //    for (int i = 0; i < Cells.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < Cells.GetLength(1); j++)
        //        {
        //            Cells[i, 0] = new Cell(new Coordinate {X = i, Y = 0 } ,Emoji.ImageForBorder);
        //            Cells[i, Cells.GetLength(0) -1] = new Cell(new Coordinate { X = i, Y = Cells.GetLength(0) - 1 }, Emoji.ImageForBorder);

        //            Cells[0, j] = new Cell(new Coordinate { X = 0, Y = j }, Emoji.ImageForBorder+ "*");
        //            Cells[Cells.GetLength(1) - 1, j] = new Cell(new Coordinate { X = Cells.GetLength(1) - 1, Y = j }, Emoji.ImageForBorder+ "*");
        //        }
        //    }
        //}

        public static void DisplayBorders()
        {
            for (int i = 0; i < numCols; i++)
            {
                Console.Write("*");
            }
        }
    }
}