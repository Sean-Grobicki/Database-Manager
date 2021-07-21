using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Manager
{
    public partial class DBManager : Form, IAddChangeLink
    {
        private APICalls _api = new APICalls();
        private List<Project> _projects;

        public DBManager()
        {
            InitializeComponent();
        }

        private async void getProjects()
        {
            _projects = await _api.getAllProjects();
            foreach (Project p in _projects)
            {
                projectBox.Items.Add(p.Title);
            }
        }

        private void DBManager_Load(object sender, EventArgs e)
        {
            getProjects();
            // Make an API call to get all projects then display the id's and titles in the project box.   
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Check that a project is selected.
            if (projectBox.SelectedIndex != -1)
            {
                // Send Patch request to API for the feels.
                // If successful send notifcation saying worked or not worked.
                getProjects();
            }
        }

        private void projectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project selectedProject = getProject(projectBox.SelectedItem.ToString());
            setLinks(selectedProject.Links);
            titleBox.Text = selectedProject.Title;
            typeBox.Text = selectedProject.Type;
            languageBox.Text = selectedProject.Language;
            descriptionTextBox.Text = selectedProject.Description;
        }

        private void setLinks(List<Link> links )
        {
            linksBox.Items.Clear();
            foreach (Link l in links)
            {
                linksBox.Items.Add(l.Url);
            }
        }

        private Project getProject(string name)
        {
            foreach (Project p in _projects)
            {
                if (p.Title == name)
                {
                    return p;
                }
            }
            return null;
        }

        private Link getLink(string url)
        {
            Project thisProject = getProject(projectBox.SelectedItem.ToString());
            foreach (Link l in thisProject.Links)
            {
                if (l.Url == url)
                {
                    return l;
                }
            }
            return null;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddProject ap = new AddProject();
            ap.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Check that a Project is selected
            if (projectBox.SelectedIndex != -1)
            {

                getProjects();
            }
            // Send Delete Request to API.
            // Show Notification on success of the request.
            
        }

        private void addLinkButton_Click(object sender, EventArgs e)
        {
            AddLink al = new AddLink("DBManager");
            al.Show();
            this.Hide();
        }

        private void linkChangeButton_Click(object sender, EventArgs e)
        {
            Link selectedLink = getLink(linksBox.SelectedItem.ToString());
            ChangeLink cl = new ChangeLink(selectedLink,"DBManager");
            cl.Show();
            this.Hide();
        }

        public void addLink(Link newLink)
        {
            Project thisProject = getProject(projectBox.SelectedItem.ToString());
            thisProject.Links.Add(newLink);
            updateLinks();
        }

        public void changeLink(string oldUrl, Link newLink)
        {
            Link oldLink = getLink(oldUrl);
            oldLink = newLink;
            updateLinks();
        }

        public void deleteLink(string url)
        {
            Project thisProject = getProject(projectBox.SelectedItem.ToString());
            Link toRemove = getLink(url);
            thisProject.Links.Remove(toRemove);
            linksBox.ClearSelected();
            updateLinks();
        }

        private void updateLinks()
        {
            Project thisProject = getProject(projectBox.SelectedItem.ToString());
            linksBox.Items.Clear();
            foreach (Link l in thisProject.Links)
            {
                linksBox.Items.Add(l.Url);
            }
        }
    }
}
