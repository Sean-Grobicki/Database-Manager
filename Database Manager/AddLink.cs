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
    public partial class AddLink : Form
    {
        private string _previousForm;
        private Link newLink = new Link();
        public AddLink(string previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms[_previousForm];
            frm.Show();
            this.Close();
        }

        private bool inputCheck()
        {
            return linkNameBox.Text != "" && linkTypeBox.SelectedIndex != -1 && linkUrlBox.Text != "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Check that all the fields have been inputted in.
            if (inputCheck())
            {
                // Use information from form to create a link object
                newLink.linkName = linkNameBox.Text;
                newLink.linkType = linkTypeBox.SelectedItem.ToString();
                newLink.url = linkUrlBox.Text;
                // Send the Link to the previous form to be added.

                IAddChangeLink frm = (IAddChangeLink)Application.OpenForms[_previousForm];
                if (frm != null)
                {
                    frm.addLink(newLink);
                    frm.Show();
                    this.Close();
                }
                else
                {
                    // Display Message saying all fields are not entered.
                }


            }
        }
    }
}
