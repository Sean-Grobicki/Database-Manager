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
        public ChangeLink(Link link, string previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
            _link = link;
            linkNameBox.Text = _link.Name;
            linkTypeBox.Text = _link.Type;
            linkUrlBox.Text = _link.Url;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Get information from the form to change the link object

            // Send the link object to the previous form.

         }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Send the LinkID back to the form for the Link that is to be deleted.
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms[_previousForm];
            frm.Show();
            this.Close();
        }
    }
}
