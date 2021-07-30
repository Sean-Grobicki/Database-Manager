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
        private string _oldUrl;
        private string _changeType = "";
        public ChangeLink(Link link, string previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
            _link = link;
            linkNameBox.Text = _link.name;
            linkTypeBox.Text = _link.type;
            linkUrlBox.Text = _link.url;
            _oldUrl = _link.url;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!fieldsEmpty())
            {
                _link.name = linkNameBox.Text;
                _link.type = linkTypeBox.SelectedItem.ToString();
                _link.url = linkUrlBox.Text;
                _changeType = "Change";
                this.Close();
            }
            else
            {
                errorMessage.Text = "Fields cannot be empty";
            }
        }

        private bool fieldsEmpty()
        {
            return linkNameBox.Text == "" || linkTypeBox.Text == "" || linkUrlBox.Text == "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _changeType = "Delete";
            if (MessageBox.Show("Are you sure you want to delete this link? ", "Database Manager",
         MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeLink_FormClosed(object sender, FormClosedEventArgs e)
        {
            IAddChangeLink frm = (IAddChangeLink)Application.OpenForms[_previousForm];
            if (_changeType == "Change")
            {
                frm.changeLink(_oldUrl, _link);
            }
            else if (_changeType == "Delete")
            {
                frm.deleteLink(_oldUrl);

            }
            frm.Show();
        }
    }
}
