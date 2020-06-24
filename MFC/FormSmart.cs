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
    }
}
