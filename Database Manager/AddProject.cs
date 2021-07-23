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
    public partial class AddProject : Form, IAddChangeLink
    {
        private Project _thisProject;
        private List<Link> _links = new List<Link>();
        public AddProject()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["DBManager"];
            frm.Show();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (inputChecks())
            {
                _thisProject = new Project(titleBox.Text, typeBox.Text, descriptionTextBox.Text, languageBox.Text);
                _thisProject.links = _links;
                DBManager frm = (DBManager)Application.OpenForms["DBManager"];
                frm.addProject(_thisProject);
                frm.Show();
                this.Close();
            }
            else
            { 
                // Error Message that all are not filled in.
            }
            
        }

        private bool inputChecks()
        {
            return titleBox.Text != null && typeBox.Text != null && descriptionTextBox.Text != null && languageBox.Text != null;
        }

        private void addLinkButton_Click(object sender, EventArgs e)
        {
            AddLink al = new AddLink("AddProject");
            al.Show();
            this.Hide();
        }

        private Link getLink(string url)
        {
            foreach (Link l in _links)
            {
                if (l.url == url)
                {
                    return l;
                }
            }
            return null;
        }

        private void linkChangeButton_Click(object sender, EventArgs e)
        {
            if (linksBox.SelectedIndex != -1)
            {
                Link link = getLink(linksBox.SelectedItem.ToString());
                ChangeLink cl = new ChangeLink(link,"AddProject");
                cl.Show();
                this.Hide();
            }
        }

        public void addLink(Link newLink)
        {
            _links.Add(newLink);
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
            Link toRemove = getLink(url);
            _links.Remove(toRemove);
            linksBox.ClearSelected();
            updateLinks();
        }

        private void updateLinks()
        {
            linksBox.Items.Clear();
            foreach (Link l in _links)
            {
                linksBox.Items.Add(l.url);
            }
        }
    }
}
