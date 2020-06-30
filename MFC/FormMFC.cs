using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MFC
{
    public partial class FormMFC : Form
    {
        public FormMFC()
        {
            InitializeComponent();
        }
        private void pictureBoxFB_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/mfckirov43/");
        }

        private void pictureBoxYouTube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCjEk-E0HAtkf-uqiFwvIueA");
        }

        private void pictureBoxVK_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/mfckirov43");
        }

        private void pictureBoxInst_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/mfckirov43/");
        }

        private void pictureBoxLenin2_Click(object sender, EventArgs e)
        {
            Form formLenin2 = new FormLenin2();
            formLenin2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxOktLeps_Click(object sender, EventArgs e)
        {
            Form formOktLeps = new FormOktLeps();
            formOktLeps.Show();
        }

        private void pictureBoxOkt_Click(object sender, EventArgs e)
        {
            Form formOkt = new FormOkt();
            formOkt.Show();
        }

        private void pictureBoxPerv_Click(object sender, EventArgs e)
        {
            Form formPerv = new FormPerv();
            formPerv.Show();
        }

        private void pictureBoxLenin_Click(object sender, EventArgs e)
        {
            Form formLenin = new FormLenin();
            formLenin.Show();
        }

        private void pictureBoxVremaProstora_Click(object sender, EventArgs e)
        {
            Form formVremaProstora = new FormVremaProstora();
            formVremaProstora.Show();
        }
    }
}
