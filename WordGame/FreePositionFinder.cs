using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace WordGame
{
    public class FreePositionFinder
    {
        private char[,] _grid;

        public FreePositionFinder(char[,] grid)
        {
            _grid = grid;
        }

        public List<Point> GetFreePositions(Point currentPosition, HashSet<Point> reservedPositions)
        {
            var freePositions = new List<Point>();

            for (int a = (int)currentPosition.X - 1; a <= (int)currentPosition.X + 1; a++)
            {
                for (int b = (int)currentPosition.Y - 1; b <= (int)currentPosition.Y + 1; b++)
                {
                    var point = new Point(a, b);
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
