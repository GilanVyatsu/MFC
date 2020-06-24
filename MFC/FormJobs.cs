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
    public partial class FormJobs : Form
    {
        public FormJobs()
        {
            InitializeComponent();
        }

        private void labelVed_Click(object sender, EventArgs e)
        {
            Form formVed = new FormVed();
            formVed.Show();
        }

        private void labelEcsp_Click(object sender, EventArgs e)
        {
            Form formEksp = new FormEksp();
            formEksp.Show();
        }

        private void labelChep_Click(object sender, EventArgs e)
        {
            Form formChep = new FormChep();
            formChep.Show();
        }
    }
}
