using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Manager
{
    public class Link
    {
        private string _linkName;
        private string _linkType;
        private string _url;

        public Link()
        { 
            
        }
        public Link(string linkName, string linkType, string url)
        {
            this.linkName = linkName;
            this.linkType = linkType;
            this.url = url;
        }

        public string linkName { get => _linkName; set => _linkName = value; }
        public string linkType { get => _linkType; set => _linkType = value; }
        public string url { get => _url; set => _url = value; }

    }
}
