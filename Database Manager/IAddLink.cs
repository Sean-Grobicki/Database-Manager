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

        void changeLink(int id, Link newLink);

        void Show();
    }
}
