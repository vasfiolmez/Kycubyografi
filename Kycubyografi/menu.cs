using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kycubyografi
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            resimSifrele resimSifrele = new resimSifrele();
            resimSifrele.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            metinSifreleCoz metinSifreleCoz = new metinSifreleCoz();
            metinSifreleCoz.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            gizliSes gizliSes = new gizliSes();
            gizliSes.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            yardimMenu yardim = new yardimMenu();
            yardim.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            siteVeriCekme siteVeriCekme = new siteVeriCekme();
            siteVeriCekme.Show();
            this.Hide();
        }
    }
}
