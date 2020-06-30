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
            Applications Applications = new Applications();
            Applications.FirstName = textBoxFirstName.Text;
            Applications.MiddleName = textBoxMiddleName.Text;
            Applications.LastName = textBoxLastName.Text;
            Applications.Appointment = textBoxAppointment.Text;
            Applications.Field = textBoxField.Text;
            Program.mFC.Applications.Add(Applications);
            Program.mFC.SaveChanges();
        }

        void ShowApplications()
        {
            listViewApplications.Items.Clear();
            foreach (Applications Applications in Program.mFC.Applications)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    Applications.id.ToString(), Applications.FirstName, Applications.MiddleName,
                    Applications.LastName, Applications.Appointment, Applications.Field
                });
                item.Tag = Applications;
                listViewApplications.Items.Add(item);
            }
            listViewApplications.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewApplications.SelectedItems.Count == 1)
            {
                Applications Applications = listViewApplications.SelectedItems[0].Tag as Applications;
                Applications.FirstName = textBoxFirstName.Text;
                Applications.MiddleName = textBoxMiddleName.Text;
                Applications.LastName = textBoxLastName.Text;
                Applications.Appointment = textBoxAppointment.Text;
                Applications.Field = textBoxField.Text;
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
                    Applications Applications = listViewApplications.SelectedItems[0].Tag as Applications;
                    Program.mFC.Applications.Remove(Applications);
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

        private void listViewApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewApplications.SelectedItems.Count == 1)
            {
                Applications Applications = listViewApplications.SelectedItems[0].Tag as Applications;
                textBoxFirstName.Text = Applications.FirstName;
                textBoxMiddleName.Text = Applications.MiddleName;
                textBoxLastName.Text = Applications.LastName;
                textBoxAppointment.Text = Applications.Appointment;
                textBoxField.Text = Applications.Field;
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
    } 
}

