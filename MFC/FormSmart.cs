using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFC
{
    public partial class FormSmart : Form
    {
        public FormSmart()
        {
            InitializeComponent();
        }

        private void labelLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://моидокументы43.рф/upload/Prikaz-_-05_OD-ot-17.05.2013-_Politika-_-Instruktsiya_.pdf");
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labeFirst_Click(object sender, EventArgs e)
        {
            Form firstQ = new FirstQ();
            firstQ.Show();
        }

        private void labeSecond_Click(object sender, EventArgs e)
        {
            Form secondQ = new SecondQ();
            secondQ.Show();
        }

        private void labeThird_Click(object sender, EventArgs e)
        {
            Form thirdQ = new ThirdQ();
            thirdQ.Show();
        }

        private void labeFourth_Click(object sender, EventArgs e)
        {
            Form fourthQ = new FourthQ();
            fourthQ.Show();
        }

        private void labeFifth_Click(object sender, EventArgs e)
        {
            Form fifthQ = new FifthQ();
            fifthQ.Show();
        }

        private void labeSixth_Click(object sender, EventArgs e)
        {
            Form sixthQ = new SixthQ();
            sixthQ.Show();
        }

        private void labelSeventh_Click(object sender, EventArgs e)
        {
            Form seventhQ = new SeventhQ();
            seventhQ.Show();
        }
    }
}
