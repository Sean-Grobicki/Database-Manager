using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Database_Manager
{
    class APICalls
    {
        HttpClient client = new HttpClient();

        public async Task<HttpStatusCode> addProject(Project project)
        {
            
        }

        public async Task<HttpStatusCode> updateProject(Project project)
        { 
        
        }

        public async Task<HttpStatusCode> deleteProject(Project project)
        { 
        
        }

        public async Task<Uri> getAllProjects()
        { 
        
        }

        public async Task<Uri> getProject(int id)
        { 
        
        }
    }
}
