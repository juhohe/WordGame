using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    public class FreePositionFinder
    {
        private char[,] _grid;

        public FreePositionFinder(char[,] grid)
        {
            _grid = grid;
        }

        public List<IntPoint> GetFreePositions(IntPoint currentPosition, HashSet<IntPoint> reservedPositions)
        {
            var freePositions = new List<IntPoint>();

            for (int a = currentPosition.X - 1; a <= currentPosition.X + 1; a++)
            {
                for (int b = currentPosition.Y - 1; b <= currentPosition.Y + 1; b++)
                {
                    var point = new IntPoint(a, b);
                    if ((a >= 0 && a < _grid.GetLength(0)) &&
                        (b >= 0 && b < _grid.GetLength(1)) &&
                        (!reservedPositions.Contains(point)))
                    {
                        freePositions.Add(point);
                    }
                }
            }

            return freePositions;
        }
    }
}
