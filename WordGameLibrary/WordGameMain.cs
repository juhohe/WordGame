using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordGameLibrary
{
    public class WordGameMain
    {
        private char[,] _grid;

        public WordGameMain()
        {
            var gridGenerator = new GameGridGenerator();
            _grid = gridGenerator.GenerateGameGrid();


        }
    }
}
