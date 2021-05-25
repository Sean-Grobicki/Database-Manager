using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Database_Manager
{
    class Project
    {
        private int _id;
        private string _title;
        private string _type;
        private string _description;
        private string _language;
        private List<Link> _links = new List<Link>();

        public Project(string title, string type, string description, string language)
        {
            Title = title;
            Type = type;
            Description = description;
            Language = language;
        }

        public string Title { get => _title; set => _title = value; }
        public string Type { get => _type; set => _type = value; }
        public string Description { get => _description; set => _description = value; }
        public string Language { get => _language; set => _language = value; }
        public int Id { get => _id; set => _id = value; }

        public void addLink(string linkName, string linkType, string url)
        {
            Link toAdd = new Link(linkName, linkType, url);
            _links.Add(toAdd);
        }

        public string getJSON()
        {
            // Get all the links in a json format

            // Add that to the json format of project under links
            return ""; 
        }


    }
}
