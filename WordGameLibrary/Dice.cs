using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGameLibrary
{
    public class Dice
    {
        private List<string> _dice = new List<string>() 
        {
            "aaeeen", "aaglää", "ahkops", "hikmnu", "akmitv", "ajoott", "nistäö",
            "aiklvy", "eiosst", "eimotu", "alnnru", "afknps", "abijsu", "eeinsu", 
            "deilrs", "elrtty"
        };        

        public Queue<char> GetRandomizedLetters()
        {
            // Getting items of the collection in randomized order.
            var randomizedDice = _dice.OrderBy(a => Guid.NewGuid());

            var letters = new Queue<char>();

            foreach (var letterChoice in randomizedDice)
            {
                var letter = letterChoice[new Random().Next(0, letterChoice.Length)];
                letters.Enqueue(letter);
            }

            return letters;
        }
    }
}
