using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinding
{
    class BreadthFirstPathfinder : Pathfinder
    {
        public override TileType[,] ShowSolutionStep(int stepNumber)
        {
            throw new NotImplementedException();
        }

        public override TileType[,] SolveMaze(TileType[,] maze)
        {
            return DrawPath(maze, FindMazeSolutionPath(maze));
        }

        private List<String> FindMazeSolutionPath(TileType[,] maze)
        {
            List<String>[,] pathToCell = new List<string>[maze.GetLength(0), maze.GetLength(1)];
            Queue<Tuple<int, int>> tileQueue = new Queue<Tuple<int, int>>();
            List<String> visitedCells = new List<string>();
            bool completed = false;
            Tuple<int, int> startLocation = FindStartLocation(maze);
            //TODO: Stop it from looking at cells it has already looked at!
            tileQueue.Enqueue(startLocation);
            pathToCell[startLocation.Item1, startLocation.Item2] = new List<String>();
            pathToCell[startLocation.Item1, startLocation.Item2].Add(startLocation.Item1 + "," + startLocation.Item2);

            while (!completed)
            {
                Tuple<int, int> currentLocation = tileQueue.Dequeue();
                visitedCells.Add(currentLocation.Item1 + "," + currentLocation.Item2);

                if (CheckDirection(maze, tileQueue, pathToCell, visitedCells, currentLocation.Item1, currentLocation.Item2, +1, 0))
                {
                    completed = true;
                }
                if (CheckDirection(maze, tileQueue, pathToCell, visitedCells, currentLocation.Item1, currentLocation.Item2, -1, 0))
                {
                    completed = true;
                }
                if (CheckDirection(maze, tileQueue, pathToCell, visitedCells, currentLocation.Item1, currentLocation.Item2, 0, +1))
                {
                    completed = true;
                }
                if (CheckDirection(maze, tileQueue, pathToCell, visitedCells, currentLocation.Item1, currentLocation.Item2, 0, -1))
                {
                    completed = true;
                }
            }
            Tuple<int, int> endLocation = FindEndLocation(maze);
            return pathToCell[endLocation.Item1, endLocation.Item2];
        }

        private bool CheckDirection(TileType[,] maze, Queue<Tuple<int, int>> tileQueue, List<String>[,] pathToCell, List<String> visitedCells, int cx, int cy, int dx, int dy)
        {
            if (CheckValidCell(maze, cx + dx, cy + dy) && !visitedCells.Contains((cx + dx) + "," + (cy + dy)))
            {
                tileQueue.Enqueue(new Tuple<int, int>(cx + dx, cy + dy));
                pathToCell[cx + dx, cy + dy] = new List<String>(pathToCell[cx, cy]);
                pathToCell[cx + dx, cy + dy].Add((cx + dx) + "," + (cy + dy));
            }
            return CheckFinish(maze, cx + dx, cy + dy);
        }

        private TileType[,] DrawPath(TileType[,] maze, List<String> path)
        {
            foreach (String step in path)
            {
                int x = Int32.Parse(step.Split(',')[0]);
                int y = Int32.Parse(step.Split(',')[1]);
                maze[x, y] = TileType.PATH;
            }
            return maze;
        }

        private bool CheckValidCell(TileType[,] maze, int x, int y)
        {
            if (!CheckOnBoard(maze, x, y))
            {
                return false;
            }
            return maze[x, y] == TileType.FLOOR || maze[x, y] == TileType.PATH;
        }

        private bool CheckFinish(TileType[,] maze, int x, int y)
        {
            Tuple<int, int> finish = FindEndLocation(maze);
            if (!CheckOnBoard(maze, x, y))
            {
                return false;
            }
            return (finish.Item1 == x && finish.Item2 == y);
        }

        private bool CheckOnBoard(TileType[,] maze, int x, int y)
        {
            int width = maze.GetLength(0);
            int height = maze.GetLength(1);
            return (x >= 0 && x < width && y >= 0 && y < height);
        }

        public override TileType[,] SolveMazeByStep(TileType[,] maze, int stepNumber)
        {
            return DrawPath(maze, FindMazeSolutionPath(maze).Take(stepNumber).ToList());
        }

        public override void SolveMazeForStepping(TileType[,] maze)
        {
            throw new NotImplementedException();
        }
    }
}
