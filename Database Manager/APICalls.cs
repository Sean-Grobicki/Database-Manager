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
        HttpClient _client = new HttpClient();
        private string _serverAddress = $"https://sean-grobicki-portfolio.vercel.app/api";

        public async Task<HttpStatusCode> addProject(Project project)
        {
            HttpResponseMessage response = await _client.PostAsync(_serverAddress + "/project",);
            response.EnsureSuccessStatusCode();
            return response.StatusCode;
        }

        public async Task<HttpStatusCode> updateProject(Project project)
        {
           
        }

        public async Task<HttpStatusCode> deleteProject(Project project)
        {
            HttpResponseMessage response = await _client.DeleteAsync(_serverAddress + "/project/"+project.Id);
            response.EnsureSuccessStatusCode();
            return response.StatusCode;
        }

        public async Task<List<Project>> getAllProjects()
        { 
            
        }

        public async Task<Project> getProject(int id)
        {
            HttpResponseMessage response = await _client.GetAsync(_serverAddress + "/project/" + id);
            response.EnsureSuccessStatusCode();

        }
    }
}
