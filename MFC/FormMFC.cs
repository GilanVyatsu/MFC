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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
