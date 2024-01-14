using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kycubyografi
{
    public partial class yuklemeEkrani : Form
    {
        public yuklemeEkrani()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                menu anamenu = new menu();
                anamenu.Show();
                this.Hide();
            }
        }
    }
}
