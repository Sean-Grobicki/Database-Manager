using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Manager
{
    interface IAddChangeLink
    {
        void addLink(Link newLink);

        void changeLink(string oldUrl, Link newLink);

        void deleteLink(string url);

        void Show();
    }
}
