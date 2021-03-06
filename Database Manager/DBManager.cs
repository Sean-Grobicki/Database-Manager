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
            errorMessage.Text = "Loading ...";
            _projects = await _api.getAllProjects();
            linksBox.Items.Clear();
            titleBox.Text = "";
            languageBox.Text = "";
            typeBox.Text = "";
            descriptionTextBox.Text = "";
            projectBox.Items.Clear();
            projectBox.ClearSelected();
            foreach (Project p in _projects)
            {
                projectBox.Items.Add(p.title);
            }
            errorMessage.Text = "";
        }

        private void DBManager_Load(object sender, EventArgs e)
        {
            getProjects();
            // Make an API call to get all projects then display the id's and titles in the project box.   
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (projectBox.SelectedIndex != -1)
            {
                Project thisProject = getProject(projectBox.SelectedItem.ToString());
                thisProject.title = titleBox.Text;
                thisProject.type = typeBox.Text;
                thisProject.description = descriptionTextBox.Text;
                thisProject.language = languageBox.Text;

                if (await _api.updateProject(thisProject))
                {
                    getProjects();
                }
                else
                {
                    errorMessage.Text = "Failed to update project";
                }
            }
            else
            {
                errorMessage.Text = "No Project Selected";
            }
        }

        private void projectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projectBox.SelectedIndex >= 0)
            {
                Project selectedProject = getProject(projectBox.SelectedItem.ToString());
                setLinks(selectedProject.links);
                titleBox.Text = selectedProject.title;
                typeBox.Text = selectedProject.type;
                languageBox.Text = selectedProject.language;
                descriptionTextBox.Text = selectedProject.description;
                errorMessage.Text = "";
            }
        }

        private void setLinks(List<Link> links )
        {
            linksBox.Items.Clear();
            foreach (Link l in links)
            {
                linksBox.Items.Add(l.url);
            }
        }

        private Project getProject(string name)
        {
            foreach (Project p in _projects)
            {
                if (p.title == name)
                {
                    return p;
                }
            }
            return null;
        }

        private Link getLink(string url)
        {
            Project thisProject = getProject(projectBox.SelectedItem.ToString());
            foreach (Link l in thisProject.links)
            {
                if (l.url == url)
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

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            // Check that a Project is selected
            if (projectBox.SelectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure you want to delete this Project? ", "Database Manager",
         MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (await _api.deleteProject(getProject(projectBox.SelectedItem.ToString())))
                    {
                        getProjects();
                    }
                    else
                    {
                        errorMessage.Text = "Failed to delete this project.";
                    }
                }
            }
            else
            {
                errorMessage.Text = "No Project Selected";
            }
            
        }

        private void addLinkButton_Click(object sender, EventArgs e)
        {
            if (projectBox.SelectedIndex != -1)
            {
                AddLink al = new AddLink("DBManager");
                al.Show();
                this.Hide();
            }
            else
            {
                errorMessage.Text = "No Project Selected";
            }
        }

        private void linkChangeButton_Click(object sender, EventArgs e)
        {
            if (linksBox.SelectedIndex != -1)
            {
                Link selectedLink = getLink(linksBox.SelectedItem.ToString());
                ChangeLink cl = new ChangeLink(selectedLink, "DBManager");
                cl.Show();
                this.Hide();
            }
            else
            {
                errorMessage.Text = "No Link Selected";
            }
        }

        public void addLink(Link newLink)
        {
            Project thisProject = getProject(projectBox.SelectedItem.ToString());
            thisProject.links.Add(newLink);
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
            thisProject.links.Remove(toRemove);
            linksBox.ClearSelected();
            updateLinks();
        }

        private void updateLinks()
        {
            Project thisProject = getProject(projectBox.SelectedItem.ToString());
            linksBox.Items.Clear();
            foreach (Link l in thisProject.links)
            {
                linksBox.Items.Add(l.url);
            }
        }

        public async void addProject(Project toAdd)
        {
            if (await _api.addProject(toAdd))
            {
                getProjects();
            }
            else
            {
                errorMessage.Text = "Failed to add project.";
            }
        }

        private void linksBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (linksBox.SelectedIndex != -1)
            {
                errorMessage.Text = "";
            }
        }

        private void DBManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Any non updated projects will be lost. Are you sure you want to close? ", "Database Manager",
         MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
            }
        }
    }
}
