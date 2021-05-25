﻿using System;
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
    public partial class DBManager : Form
    {
        private APICalls _api = new APICalls();
        private List<Project> _projects;

        public DBManager()
        {
            InitializeComponent();
            getProjects();
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
            // Make an API call to get all projects then display the id's and titles in the project box.   
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}