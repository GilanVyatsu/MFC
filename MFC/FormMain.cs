﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFC
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonMFC_Click(object sender, EventArgs e)
        {
            {
                Form formMFC = new FormMFC();
                formMFC.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonContacts_Click(object sender, EventArgs e)
        {
            Form formContacts = new FormContacts();
            formContacts.Show();
        }

        private void buttonJobs_Click(object sender, EventArgs e)
        {
            Form formJobs = new FormJobs();
            formJobs.Show();
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            Form formServices = new FormServices();
            formServices.Show();
        }
    }
}
