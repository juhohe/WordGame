using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordGameLibrary;
using System.Diagnostics;

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
        public void TestGettingWordsFromKotusXmlWordList()
        {
            var helper = new GetXmlFromFileHelper();

            int wordCount = 94110;

            IEnumerable<string> words = helper.GetWordsFromKotusXmlWordList();

            Assert.IsTrue(words != null && words.Any() && words.Count() == wordCount);
        }

        [TestMethod]
        public void TestCreateTrieStructureOfWordList()
        {
            var trieHelper = new WordTrieHelper();

            var trie = trieHelper.GetTrie();

            Assert.IsTrue(trie != null && trie.Retrieve("aamu").Any());
        }

        [TestMethod]
        public void TestGetWordsFromGrid()
        {
            var gridGenerator = new GameGridGenerator();

            char[,] grid = gridGenerator.GenerateGameGrid();

            var gridTraverser = new GridTraverser(grid);

            HashSet<string> foundWords = gridTraverser.FindWordsOnGrid();            

            Assert.IsTrue(foundWords.Any());
        }

        //[TestMethod]
        //// Testing finding automatically all possible letter combinations from the game grid.
        //public void TestGetLetterCombinations()
        //{
        //    var gridGenerator = new GameGridGenerator();
        //    var grid = gridGenerator.GenerateGameGrid();

        //    var letterCombinationFinder = new LetterCombinationFinder(grid);

        //    var letterCombinations = letterCombinationFinder.GetLetterCombinations();

        //    Assert.IsTrue(letterCombinations != null && letterCombinations.Count > 0 &&
        //        letterCombinations.First().GetType() == typeof(string));
        //}        
    }
}
