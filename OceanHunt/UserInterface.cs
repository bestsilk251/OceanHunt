using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanHunt
{
    class UserInterface
    {
        public static void GettingValues()
        {
            Ocean._iterationCounter = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number of rows DEFAULT = {Ocean._numRows}");
            Ocean._numRows = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number of columns DEFAULT = {Ocean._numCols}");
            Ocean._numCols = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number of preys DEFAULT = {Ocean._numPrey}");
            Ocean._numPrey = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number of predators DEFAULT = {Ocean._numPredators}");
            Ocean._numPredators = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number of obstacles DEFAULT = {Ocean._numObstacles}");
            Ocean._numObstacles = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"Number of interations: {Ocean._iterationCounter}");
            Console.WriteLine($"Your size is: {Ocean._numRows * Ocean._numCols}");
            Console.WriteLine($"Number of rows: {Ocean._numRows}");
            Console.WriteLine($"Number of columns: {Ocean._numCols}");
            Console.WriteLine($"Number of preys: {Ocean._numPrey}");
            Console.WriteLine($"Number of predators: {Ocean._numPredators}");
            Console.WriteLine($"Number of obstacles: {Ocean._numObstacles}");
            Console.WriteLine("OCEAN HUNT");

            Ocean.Run(Ocean._iterationCounter);
        }

    }
}
