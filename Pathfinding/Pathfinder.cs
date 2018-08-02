using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinding
{
    abstract class Pathfinder
    {
        public abstract TileType[,] SolveMaze(TileType[,] maze);
        public abstract TileType[,] SolveMazeByStep(TileType[,] maze, int stepNumber);
        public abstract TileType[,] ShowSolutionStep(int stepNumber);
        public abstract void SolveMazeForStepping(TileType[,] maze);

        public Tuple<int, int> FindStartLocation(TileType[,] maze)
        {
            return FindFloorInRow(maze, 0);
        }

        public Tuple<int, int> FindEndLocation(TileType[,] maze)
        {
            return FindFloorInRow(maze, maze.GetLength(1) - 1);
        }

        private Tuple<int, int> FindFloorInRow(TileType[,] maze, int y)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                if (maze[i, y] == TileType.FLOOR || maze[i, y] == TileType.PATH)
                {
                    return new Tuple<int, int>(i, y);
                }
            }
            throw new Exception();
        }
    }
}
