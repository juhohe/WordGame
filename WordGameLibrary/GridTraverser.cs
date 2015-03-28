using Gma.DataStructures.StringSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGameLibrary
{
    public class GridTraverser
    {
        private char[,] _grid;
        private FreePositionFinder _freePositionFinder;
        private ITrie<string> _vocabulary;
        private HashSet<string> _foundWords;

        public GridTraverser(char[,] grid)
        {
            _grid = grid;
            _freePositionFinder = new FreePositionFinder(_grid);
            _vocabulary = new WordTrieHelper().GetTrie();
            _foundWords = new HashSet<string>();
        }

        public HashSet<string> FindWordsOnGrid()
        {
            var width = _grid.GetLength(0);
            var height = _grid.GetLength(1);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    GetLetterCombinationsFromGridPosition(new IntPoint(i, j), new HashSet<IntPoint>(), new StringBuilder());
                }
            }

            return _foundWords;
        }

        private void GetLetterCombinationsFromGridPosition(IntPoint position, HashSet<IntPoint> reservedPositions, StringBuilder sb)
        {
            reservedPositions.Add(position);

            sb.Append(_grid[position.X, position.Y]);

            var trieResult = _vocabulary.Retrieve(sb.ToString());

            if (!trieResult.Any())
            {
                return;
            }
            else
            {
                if (trieResult.Any(t => t == sb.ToString())) {
                    _foundWords.Add(sb.ToString());
                }
            }

            List<IntPoint> freePositions = _freePositionFinder.GetFreePositions(position, reservedPositions);

            foreach (IntPoint freePosition in freePositions)
            {
                GetLetterCombinationsFromGridPosition(freePosition, new HashSet<IntPoint>(reservedPositions), new StringBuilder(sb.ToString()));
            }
        }

    }
}
