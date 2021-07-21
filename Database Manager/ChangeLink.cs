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
    public partial class ChangeLink : Form
    {
        private string _previousForm;
        private Link _link;
        private string oldUrl;
        public ChangeLink(Link link, string previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
            _link = link;
            linkNameBox.Text = _link.Name;
            linkTypeBox.Text = _link.Type;
            linkUrlBox.Text = _link.Url;
            oldUrl = _link.Url;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Get information from the form to change the link object

            // Send the link object to the previous form.
            // Use information from form to create a link object
            _link.Name = linkNameBox.Text;
            _link.Type = linkTypeBox.SelectedItem.ToString();
            _link.Url = linkUrlBox.Text;
            // Send the Link to the previous form to be added.

            IAddChangeLink frm = (IAddChangeLink)Application.OpenForms[_previousForm];
            if (frm != null)
            {
               frm.changeLink(oldUrl,_link);
               frm.Show();
               this.Close();
            }
            else
            {
                 // Display Message saying all fields are not entered.
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            IAddChangeLink frm = (IAddChangeLink)Application.OpenForms[_previousForm];
            if (frm != null)
            {
                frm.deleteLink(oldUrl);
                frm.Show();
                this.Close();
            }
            else
            {
                // Display Message saying all fields are not entered.
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms[_previousForm];
            frm.Show();
            this.Close();
        }
    }
}
