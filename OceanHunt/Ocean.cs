using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OceanHunt
{
    public static class Ocean
    {
        static int numRows = 25;            // число рядків
        static int numCols = 70;            // число стовпців
        static int size = numCols * numRows;
        static int numPrey = 150;          // жертви
        static int numPredators = 20;      // хижаки
        static int numObstacles = 75;      // перешкоди

        //public static int Run(int iterationCounter)
        //{

        //}
        public static void PrintInfo()
        {
            Console.WriteLine("Enter number of rows: {0}", numRows);
            Console.WriteLine("Enter number of columns:  {0}", numCols);
            Console.WriteLine("Enter number of preys: {0}", numPrey);
            Console.WriteLine("Enter number of predators: {0}", numPredators);
            Console.WriteLine("Enter number of obstacles: {0}", numObstacles);
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}