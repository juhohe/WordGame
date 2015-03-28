using Gma.DataStructures.StringSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WordGame
{
    public class WordTrieHelper
    {
        public IEnumerable<string> GetWordsFromKotusXmlWordList()
        {            
            XDocument doc = XDocument.Load(@"kotus-sanalista_v1\kotus-sanalista_v1.xml");

            return doc.Descendants("s").Select(s => s.Value);
        }
    }
}
