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
        }
        private void listViewApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewApplications.SelectedItems.Count == 1)
            {
                Applications applications = listViewApplications.SelectedItems[0].Tag as Applications;
                textBoxFirstName.Text = applications.FirstName;
                textBoxMiddleName.Text = applications.MiddleName;
                textBoxLastName.Text = applications.LastName;
            }

            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Applications applications = new Applications();
            applications.FirstName = textBoxFirstName.Text;
            applications.MiddleName = textBoxMiddleName.Text;
            applications.LastName = textBoxLastName.Text;
            Program.mFC.Applications.Add(applications);
            Program.mFC.SaveChanges();
        }
        void ShowPersonal()
        {
            listViewApplications.Items.Clear();
            foreach (Applications applications in Program.mFC.Applications)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    applications.id.ToString(), applications.FirstName, applications.MiddleName,
                    applications.LastName,
                });
                item.Tag = applications;
                listViewApplications.Items.Add(item);
            }
            listViewApplications.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewApplications.SelectedItems.Count == 1)
            {
                Applications applications = listViewApplications.SelectedItems[0].Tag as Applications;
                applications.FirstName = textBoxFirstName.Text;
                applications.MiddleName = textBoxMiddleName.Text;
                applications.LastName = textBoxLastName.Text;
                Program.mFC.SaveChanges();
                ShowPersonal();
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
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется!", "ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
