using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinding
{
    public partial class Form1 : Form
    {
        Bitmap originalImage;
        Bitmap workingImage;

        int stepNumber = 1;

        Pathfinder[] pathFinders = new Pathfinder[4];

        bool finderAlreadySolved = false;

        public Form1()
        {
            InitializeComponent();
            pctMaze.SizeMode = PictureBoxSizeMode.StretchImage;
            pathFinders[0] = new RandomPathfinder();
            pathFinders[1] = new AStarPathfinder();
            pathFinders[2] = new NodePathfinder();
            pathFinders[3] = new BreadthFirstPathfinder();

            cmbPathFindingType.Items.Add("Random");
            cmbPathFindingType.Items.Add("A*");
            cmbPathFindingType.Items.Add("Node based");
            cmbPathFindingType.Items.Add("Breadth-First");
        }

        private void SetNewImage(Bitmap newImage)
        {
            originalImage = newImage;
            SetImage(newImage);
            stepNumber = 1;
        }

        private void SetImage(Bitmap newImage)
        {
            workingImage = newImage;
            pctMaze.Image = newImage;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Bitmap Picture Files|*.bmp",
                Title = "Select a Bitmap Picture File"
            };
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                SetNewImage(bitmap);
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetImage(originalImage);
            stepNumber = 1;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Bitmap Picture File|*.bmp",
                Title = "Save your Image"
            };
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                originalImage.Save(saveFileDialog.FileName);
            }
        }

        private void DrawImage(TileType[,] tiles)
        {
            Bitmap bitmap = new Bitmap(workingImage);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    switch (tiles[x, y])
                    {
                        case TileType.WALL:
                            bitmap.SetPixel(x, y, Color.Black);
                            break;
                        case TileType.FLOOR:
                            bitmap.SetPixel(x, y, Color.White);
                            break;
                        case TileType.PATH:
                            bitmap.SetPixel(x, y, Color.Red);
                            break;
                    }

                }
            }
            SetImage(bitmap);
        }

        private TileType[,] convertImageToTiles(Bitmap image)
        {
            TileType[,] tiles = new TileType[image.Width, image.Height];
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    int r = image.GetPixel(x, y).R;
                    int g = image.GetPixel(x, y).G;
                    int b = image.GetPixel(x, y).B;
                    if (r + g + b == 0)
                    {
                        tiles[x, y] = TileType.WALL;
                    }
                    else if (r + g + b == 255)
                    {
                        tiles[x, y] = TileType.PATH;
                    }
                    else if (r + g + b == 765)
                    {
                        tiles[x, y] = TileType.FLOOR;
                    }

                }
            }
            return tiles;
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            //Complete the whole maze and show the completed image
            Pathfinder pathfinder = GetChosenPathfinder();
            TileType[,] tiles = pathfinder.SolveMaze(convertImageToTiles(workingImage));
            DrawImage(tiles);
        }

        private void BtnStepByStep_Click(object sender, EventArgs e)
        {
            //Complete the whole maze one step at a time, with a small gap between draws
            stepTimer.Start();
        }

        private void BtnSingleStep_Click(object sender, EventArgs e)
        {
            SingleStep();
        }

        private bool SingleStep()
        {
            //Complete a single step of the maze
            Pathfinder pathfinder = GetChosenPathfinder();
            TileType[,] tiles = pathfinder.SolveMazeByStep(convertImageToTiles(workingImage), stepNumber);
            DrawImage(tiles);
            stepNumber++;
            Tuple<int, int> endLocation = pathfinder.FindEndLocation(tiles);
            return tiles[endLocation.Item1, endLocation.Item2] == TileType.PATH;
        }

        private Pathfinder GetChosenPathfinder()
        {
            return pathFinders[cmbPathFindingType.SelectedIndex];
        }

        private void stepTimer_Tick(object sender, EventArgs e)
        {
            if (SingleStep())
            {
                stepTimer.Stop();
            }

        }
    }
}
