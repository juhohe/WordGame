using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WordGameLibrary
{
    public class GetXmlFromFileHelper
    {
        public IEnumerable<string> GetWordsFromKotusXmlWordList()
        {
            XDocument doc = XDocument.Load(@"kotus-sanalista_v1\kotus-sanalista_v1.xml");

            return doc.Descendants("s").Where(s => s.Value.Length > 2).Select(s => s.Value.ToLowerInvariant());
        }
    }
}
