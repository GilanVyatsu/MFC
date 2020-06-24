using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFC
{
    public partial class FormPaid : Form
    {
        public FormPaid()
        {
            InitializeComponent();
        }

        private void labelLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://моидокументы43.рф/upload/Prikaz-_-05_OD-ot-17.05.2013-_Politika-_-Instruktsiya_.pdf");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form formPolis = new FormPolis();
            formPolis.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form formStrahovanie = new FormStrahovanie();
            formStrahovanie.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form formUrLico = new FormUrLico();
            formUrLico.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form formFizLico = new FormFizLico();
            formFizLico.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form formHouse = new FormHouse();
            formHouse.Show();
        }
    }
}
