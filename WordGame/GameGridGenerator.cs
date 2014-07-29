using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    public class GameGridGenerator
    {             
        public char[,] GenerateGameGrid()
        {            
            var lettersOnGrid = new Dice().GetRandomizedLetters();

            var width = 4;
            var height = 4;

            var grid = new char[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    grid[i, j] = lettersOnGrid.Dequeue();
                }
            }

            return grid;            
        }        
    }
}
