using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace WordGame
{
    public class LetterCombinationFinder
    {
        private char[,] _grid;
        HashSet<string> _letterCombinations;

        private FreePositionFinder _freePositionFinder;

        public LetterCombinationFinder(char[,] grid)
        {
            _grid = grid;
            _freePositionFinder = new FreePositionFinder(_grid);
        }

        public HashSet<string> GetLetterCombinations()
        {
            if (_letterCombinations != null)
            {
                return _letterCombinations;
            }

            _letterCombinations = new HashSet<string>();

            var width = _grid.GetLength(0);
            var height = _grid.GetLength(1);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    GetLetterCombinationsFromGridPosition(new Point(i, j), new HashSet<Point>(), new StringBuilder());
                }
            }

            return _letterCombinations;
        }

        private void GetLetterCombinationsFromGridPosition(Point position, HashSet<Point> reservedPositions, StringBuilder sb)
        {
            reservedPositions.Add(position);

            sb.Append(_grid[(int)position.X, (int)position.Y]);

            _letterCombinations.Add(sb.ToString());

            List<Point> freePositions = _freePositionFinder.GetFreePositions(position, reservedPositions);

            foreach (Point freePosition in freePositions)
            {
                GetLetterCombinationsFromGridPosition(freePosition, new HashSet<Point>(reservedPositions), new StringBuilder(sb.ToString()));
            }
        }
    }
}
