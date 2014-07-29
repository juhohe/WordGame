using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using WordGame;

namespace WordGameTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // Checking if the tested method returns a non null, non empty collection of characters.
        public void TestGetRandomizedLetters()
        {
            var dice = new Dice();

            var letters = dice.GetRandomizedLetters();

            Assert.IsTrue(letters != null && letters.Count > 0 && letters.All(c => c.GetType() == typeof(char)));
        }

        [TestMethod]
        // Testing that the game grid generation returns a non null, non empty two-dimensional
        // collection of characters.
        public void TestGetGameGrid()
        {
            var gridGenerator = new GameGridGenerator();

            var grid = gridGenerator.GenerateGameGrid();

            Assert.IsTrue(grid != null && grid.Length > 0 && grid.Rank == 2 && grid[0, 0].GetType() == typeof(char));
        }

        [TestMethod]
        public void TestGetLetterCombinations()
        {
            var gridGenerator = new GameGridGenerator();
            var grid = gridGenerator.GenerateGameGrid();

            var letterCombinationFinder = new LetterCombinationFinder(grid);

            var letterCombinations = letterCombinationFinder.GetLetterCombinations();

            Assert.IsTrue(letterCombinations != null && letterCombinations.Count > 0 &&
                letterCombinations.First().GetType() == typeof(string));
        }
    }
}
