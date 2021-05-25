using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net.Http.Headers;
using Newtonsoft.Json; 

namespace Database_Manager
{
    class APICalls
    {
        HttpClient _client = new HttpClient();
        private string _serverAddress = $"https://sean-grobicki-portfolio.vercel.app";


        public APICalls()
        {
            _client.BaseAddress = new Uri(_serverAddress);
        }

        //public async Task<HttpStatusCode> addProject(Project project)
        //{
        //    //HttpResponseMessage response = await _client.PostAsync(_serverAddress + "/project",project);
        //    //response.EnsureSuccessStatusCode();
        //    //return response.StatusCode;
        //}

        //public async Task<HttpStatusCode> updateProject(Project project)
        //{
           
        //}

        //public async Task<HttpStatusCode> deleteProject(Project project)
        //{
        //    HttpResponseMessage response = await _client.DeleteAsync(_serverAddress + "/project/"+project.Id);
        //    response.EnsureSuccessStatusCode();
        //    return response.StatusCode;
        //}

        public async Task<List<Project>> getAllProjects()
        {
            string serialisedJson = await _client.GetStringAsync($"/api/projects");
            List<Project> allProjects = JsonConvert.DeserializeObject<List<Project>>(serialisedJson);
            return allProjects;
        }

        //public async Task<Project> getProject(int id)
        //{
        //    HttpResponseMessage response = await _client.GetAsync(_serverAddress + "/project/" + id);
        //    response.EnsureSuccessStatusCode();

        //}
    }
}

