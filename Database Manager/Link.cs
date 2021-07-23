using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Manager
{
    public class Link
    {
        private int _linkID;
        private string _linkName;
        private string _linkType;
        private string _url;

        public Link()
        { 
            
        }
        public Link(string linkName, string linkType, string url)
        {
            this.name = linkName;
            this.type = linkType;
            this.url = url;
        }

        public int linkID { get => _linkID; set => _linkID = value; }
        public string name { get => _linkName; set => _linkName = value; }
        public string type { get => _linkType; set => _linkType = value; }
        public string url { get => _url; set => _url = value; }

    }
}
