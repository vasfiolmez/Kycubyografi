using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kycubyografi
{
    public partial class metinSifreleCoz : Form
    {
        public metinSifreleCoz()
        {
            InitializeComponent();
        }
        AesSifreleveCoz aes = new AesSifreleveCoz();
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = aes.AesSifrele(richTextBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = aes.AesSifre_coz(richTextBox2.Text);
        }
    }
}
