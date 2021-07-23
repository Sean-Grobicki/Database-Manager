using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Database_Manager
{
    public class Project
    {
        private int _id;
        private string _title;
        private string _type;
        private string _description;
        private string _language;
        private List<Link> _links;

        public Project(string title, string type, string description, string language)
        {
            this.title = title;
            this.type = type;
            this.description = description;
            this.language = language;
        }

        public int projectId { get => _id; set => _id = value; }
        public string title { get => _title; set => _title = value; }
        public string type { get => _type; set => _type = value; }
        public string description { get => _description; set => _description = value; }
        public string language { get => _language; set => _language = value; }
        public List<Link> links { get => _links; set => _links = value; }

    }
}
