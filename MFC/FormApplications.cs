using System;
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
    public partial class FormApplications : Form
    {
        public FormApplications()
        {
            InitializeComponent();
            ShowApplications();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Applications applications = new Applications();
            applications.FirstName = textBoxFirstName.Text;
            applications.MiddleName = textBoxMiddleName.Text;
            applications.LastName = textBoxLastName.Text;
            applications.Appointment = textBoxAppointment.Text;
            applications.Field = textBoxField.Text;
            Program.mFC.Applications.Add(applications);
        }
        void ShowApplications()
        {
            listViewApplications.Items.Clear();
            foreach (Applications applications in Program.mFC.Applications)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    applications.id.ToString(), applications.FirstName, applications.MiddleName,
                    applications.LastName, applications.Appointment, applications.Field
                });
                item.Tag = applications;
                listViewApplications.Items.Add(item);
            }
            listViewApplications.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewApplications.SelectedItems.Count == 1)
            {
                Applications applications = listViewApplications.SelectedItems[0].Tag as Applications;
                textBoxFirstName.Text = applications.FirstName;
                textBoxMiddleName.Text = applications.MiddleName;
                textBoxLastName.Text = applications.LastName;
                textBoxAppointment.Text = applications.Appointment;
                textBoxField.Text = applications.Field;
            }

            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxAppointment.Text = "";
                textBoxField.Text = "";
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewApplications.SelectedItems.Count == 1)
            {
                Applications applications = listViewApplications.SelectedItems[0].Tag as Applications;
                applications.FirstName = textBoxFirstName.Text;
                applications.MiddleName = textBoxMiddleName.Text;
                applications.LastName = textBoxLastName.Text;
                applications.Appointment = textBoxAppointment.Text;
                applications.Field = textBoxField.Text;
                Program.mFC.SaveChanges();
                ShowApplications();
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewApplications.SelectedItems.Count == 1)
                {
                    Applications applications = listViewApplications.SelectedItems[0].Tag as Applications;
                    Program.mFC.Applications.Remove(applications);
                    Program.mFC.SaveChanges();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxAppointment.Text = "";
                textBoxField.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется!", "ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxField_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}

