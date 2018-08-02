using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinding
{
    class RandomPathfinder : Pathfinder
    {
        HashSet<String> visitedTiles = new HashSet<string>();
        HashSet<String> unCompletedTiles = new HashSet<string>();

        public override TileType[,] SolveMaze(TileType[,] maze)
        {
            /**bool completed = false;
            Tuple<int, int> startLocation = FindStartLocation(maze);
            Tuple<int, int> endLocation = FindEndLocation(maze);
            int width = maze.GetLength(0);
            int height = maze.GetLength(1);

            unCompletedTiles.Add(startLocation.Item1 + "," + startLocation.Item2);
            while (!completed)
            {
                foreach (String tileName in unCompletedTiles)
                {
                    int x = Int32.Parse(tileName.Split(',')[0]);
                    int y = Int32.Parse(tileName.Split(',')[1]);
                    visitedTiles.Add(x + "," + y);

                    if (CheckCompletedTile(maze, x, y))
                    {

                    }
                }
                completed = CheckCompletedTile();
            }
    **/
            return maze;
        }

        private bool CheckCompletedTile(TileType[,] maze, int x, int y)
        {
            int width = maze.GetLength(0);
            int height = maze.GetLength(1);
            if (x - 1 >= 0 && maze[x - 1, y] == TileType.FLOOR && !visitedTiles.Contains((x - 1) + "," + y))
            {
                return false;
            }

            if (y - 1 >= 0 && maze[x, y - 1] == TileType.FLOOR && !visitedTiles.Contains((x) + "," + (y - 1)))
            {
                return false;
            }

            if (x + 1 < width && maze[x + 1, y] == TileType.FLOOR && !visitedTiles.Contains((x + 1) + "," + y))
            {
                return false;
            }

            if (y + 1 < height && maze[x, y + 1] == TileType.FLOOR && !visitedTiles.Contains(x + "," + (y + 1)))
            {
                return false;
            }

            return true;
        }

        public override TileType[,] ShowSolutionStep(int stepNumber)
        {
            throw new NotImplementedException();
        }

        public override TileType[,] SolveMazeByStep(TileType[,] maze, int stepNumber)
        {
            throw new NotImplementedException();
        }

        public override void SolveMazeForStepping(TileType[,] maze)
        {
            throw new NotImplementedException();
        }
    }
}
