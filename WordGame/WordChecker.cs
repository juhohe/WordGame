using libvoikko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    public class WordChecker
    {
        private Voikko _voikko;
        private ICollection<string> _wordsToCheck;

        public WordChecker(ICollection<string> wordsToCheck)
        {
            _voikko = new Voikko("fi");
            _wordsToCheck = wordsToCheck;
        }

    }
}
