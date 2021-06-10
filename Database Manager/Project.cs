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
        private List<Link> _links;

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
        public List<Link> Links { get => _links; set => _links = value; }

        public void addLink(string linkName, string linkType, string url)
        {
            Link toAdd = new Link(Links.Count,linkName, linkType, url);
            Links.Add(toAdd);
        }
        public void showLinks()
        {
            foreach (Link l in Links)
            {
                Console.WriteLine(l.LinkId + " " + l.Name + " " + l.Type + " " + l.Url);
            }
        }
        public string getJSON()
        {
            // Get all the links in a json format

            // Add that to the json format of project under links
            return ""; 
        }


    }
}
