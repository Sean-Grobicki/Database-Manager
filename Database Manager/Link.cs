using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Manager
{
    class Link
    {
        private string _linkName;
        private string _linkType;
        private string _url;

        public Link(string linkName, string linkType, string url)
        {
            LinkName = linkName;
            LinkType = linkType;
            Url = url;
        }

        public string LinkName { get => _linkName; set => _linkName = value; }
        public string LinkType { get => _linkType; set => _linkType = value; }
        public string Url { get => _url; set => _url = value; }

        public string getJSON()
        {
            return "";
        }

    }
}
