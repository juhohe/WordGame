using Gma.DataStructures.StringSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WordGameLibrary
{
    public class WordTrieHelper
    {
        public ITrie<string> GetTrie()
        {
            var xmlWordHelper = new GetXmlFromFileHelper();

            IEnumerable<string> words = xmlWordHelper.GetWordsFromKotusXmlWordList();

            ITrie<string> trie = new Trie<string>();            

            foreach (string word in words)
            {                
                trie.Add(word, word);
            }            
                
            return trie;
        }
    }
}
