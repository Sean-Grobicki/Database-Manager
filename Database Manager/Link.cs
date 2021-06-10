using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Manager
{
    public class Link
    {
        private int _id;
        private string _linkName;
        private string _linkType;
        private string _url;

        public Link()
        { 
            
        }
        public Link(int id, string linkName, string linkType, string url)
        {
            LinkId = id;
            Name = linkName;
            Type = linkType;
            Url = url;
        }

        public string Name { get => _linkName; set => _linkName = value; }
        public string Type { get => _linkType; set => _linkType = value; }
        public string Url { get => _url; set => _url = value; }
        public int LinkId { get => _id; set => _id = value; }

        public string getJSON()
        {
            return "";
        }

    }
}
