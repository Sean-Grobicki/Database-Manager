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
    public partial class AddProject : Form
    {
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
            Form frm = Application.OpenForms["DBManager"];
            frm.Show();
            this.Close();
        }

        private void addLinkButton_Click(object sender, EventArgs e)
        {
            AddLink al = new AddLink("AddProject");
            al.Show();
            this.Hide();
        }

        private Link getLink(string url)
        { 
                    
        }

        private void linkChangeButton_Click(object sender, EventArgs e)
        {
            if (linksBox.SelectedIndex != -1)
            {
                ChangeLink cl = new ChangeLink("AddProject");
                cl.Show();
                this.Hide();
            }
            
        }
    }
}
