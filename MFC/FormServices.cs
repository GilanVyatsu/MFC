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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }

        private void buttonPaid_Click(object sender, EventArgs e)
        {
            Form formPaid = new FormPaid();
            formPaid.Show();
        }

        private void buttonSmart_Click(object sender, EventArgs e)
        {
            Form formSmart = new FormSmart();
            formSmart.Show();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
