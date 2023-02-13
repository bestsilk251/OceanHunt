using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanHunt
{
    class UserInterface
    {
        public static void GettingValues()
        {
            Run(Ocean.interationCounter);
            Ocean.interationCounter = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number of rows DEFAULT = {Ocean.numRows}");
            Ocean.numRows = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number of columns DEFAULT = {Ocean.numCols}");
            Ocean.numCols = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number of preys DEFAULT = {Ocean.numPrey}");
            Ocean.numPrey = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number of predators DEFAULT = {Ocean.numPredators}");
            Ocean.numPredators = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number of obstacles DEFAULT = {Ocean.numObstacles}");
            Ocean.numObstacles = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"Number of interations: {Ocean.interationCounter}");
            Console.WriteLine($"Your size is: {Ocean.numRows * Ocean.numCols}");
            Console.WriteLine($"Number of rows: {Ocean.numRows}");
            Console.WriteLine($"Number of columns: {Ocean.numCols}");
            Console.WriteLine($"Number of preys: {Ocean.numPrey}");
            Console.WriteLine($"Number of predators: {Ocean.numPredators}");
            Console.WriteLine($"Number of obstacles: {Ocean.numObstacles}");

            Ocean.Cells = Ocean.InitCells(Ocean.numRows, Ocean.numCols);

            //DisplayBorder(numRows);
            //DisplayBorder(cells);
            Ocean.DisplayCells(Ocean.Cells);
            //DisplayBorder(numRows);
        }

        public static void Run(int iterationCounter)
        {
            Console.WriteLine($"Enter the number of interations DEFAULT = {iterationCounter}");
        }
    }
}
