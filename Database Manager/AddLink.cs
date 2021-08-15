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
            this.Close();
        }

        private bool inputCheck()
        {
            return linkNameBox.Text != "" && linkTypeBox.Text != "" && linkUrlBox.Text != "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Check that all the fields have been inputted in.
            if (inputCheck())
            {
                // Use information from form to create a link object
                newLink.name = linkNameBox.Text;
                newLink.type = linkTypeBox.SelectedItem.ToString();
                newLink.url = linkUrlBox.Text;
                // Send the Link to the previous form to be added.
                this.Close();
            }
            else
            {
                errorMessage.Text = "All Fields are required";
            }


        }

        private void AddLink_FormClosed(object sender, FormClosedEventArgs e)
        {
            IAddChangeLink frm = (IAddChangeLink)Application.OpenForms[_previousForm];
            if (newLink.name != null)
            {
                frm.addLink(newLink);
            }
            frm.Show();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
