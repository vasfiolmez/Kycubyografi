namespace Kycubyografi
{
    partial class resimSifrele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resimSifrele));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelProgress = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtMetinSifrele = new TextBox();
            btnKaydet = new Button();
            btnSifrele = new Button();
            progressBar1 = new ProgressBar();
            groupBox1 = new GroupBox();
            labelImageSize = new Label();
            pBsifrelecekResim = new PictureBox();
            txtSifrelecekResimYolu = new TextBox();
            btndosyaAc = new Button();
            tabPage2 = new TabPage();
            label4 = new Label();
            progressBar2 = new ProgressBar();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            label3 = new Label();
            txtGizliYazı = new TextBox();
            btnSifreCoz = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btnSifreliDosyasec = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBsifrelecekResim).BeginInit();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 31);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(790, 454);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.BackgroundImageLayout = ImageLayout.Center;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(labelProgress);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            tabPage1.ForeColor = SystemColors.Desktop;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(782, 426);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Resim Şifrele";
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(19, 390);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(11, 15);
            labelProgress.TabIndex = 6;
            labelProgress.Text = "-";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtMetinSifrele);
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Controls.Add(btnSifrele);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(397, 17);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(360, 335);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gizlemek İstediğin Mesajı Yaz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 303);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "Metin Uzunluğu:";
            // 
            // txtMetinSifrele
            // 
            txtMetinSifrele.Location = new Point(5, 18);
            txtMetinSifrele.Margin = new Padding(3, 2, 3, 2);
            txtMetinSifrele.Multiline = true;
            txtMetinSifrele.Name = "txtMetinSifrele";
            txtMetinSifrele.Size = new Size(350, 247);
            txtMetinSifrele.TabIndex = 1;
            txtMetinSifrele.TextChanged += txtMetinSifrele_TextChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.ForeColor = Color.Black;
            btnKaydet.Location = new Point(240, 270);
            btnKaydet.Margin = new Padding(3, 2, 3, 2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(103, 28);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSifrele
            // 
            btnSifrele.Enabled = false;
            btnSifrele.ForeColor = Color.Black;
            btnSifrele.Location = new Point(131, 269);
            btnSifrele.Margin = new Padding(3, 2, 3, 2);
            btnSifrele.Name = "btnSifrele";
            btnSifrele.Size = new Size(103, 29);
            btnSifrele.TabIndex = 0;
            btnSifrele.Text = "Şifrele";
            btnSifrele.UseVisualStyleBackColor = true;
            btnSifrele.Click += btnSifrele_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(16, 357);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(742, 29);
            progressBar1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelImageSize);
            groupBox1.Controls.Add(pBsifrelecekResim);
            groupBox1.Controls.Add(txtSifrelecekResimYolu);
            groupBox1.Controls.Add(btndosyaAc);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(16, 17);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(376, 335);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resim";
            // 
            // labelImageSize
            // 
            labelImageSize.AutoSize = true;
            labelImageSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelImageSize.ForeColor = Color.Black;
            labelImageSize.Location = new Point(19, 303);
            labelImageSize.Name = "labelImageSize";
            labelImageSize.Size = new Size(71, 15);
            labelImageSize.TabIndex = 3;
            labelImageSize.Text = "Image Size:";
            // 
            // pBsifrelecekResim
            // 
            pBsifrelecekResim.Location = new Point(5, 18);
            pBsifrelecekResim.Margin = new Padding(3, 2, 3, 2);
            pBsifrelecekResim.Name = "pBsifrelecekResim";
            pBsifrelecekResim.Size = new Size(366, 246);
            pBsifrelecekResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pBsifrelecekResim.TabIndex = 1;
            pBsifrelecekResim.TabStop = false;
            // 
            // txtSifrelecekResimYolu
            // 
            txtSifrelecekResimYolu.Location = new Point(19, 269);
            txtSifrelecekResimYolu.Margin = new Padding(3, 2, 3, 2);
            txtSifrelecekResimYolu.Multiline = true;
            txtSifrelecekResimYolu.Name = "txtSifrelecekResimYolu";
            txtSifrelecekResimYolu.Size = new Size(248, 29);
            txtSifrelecekResimYolu.TabIndex = 2;
            // 
            // btndosyaAc
            // 
            btndosyaAc.ForeColor = Color.Black;
            btndosyaAc.Location = new Point(272, 270);
            btndosyaAc.Margin = new Padding(3, 2, 3, 2);
            btndosyaAc.Name = "btndosyaAc";
            btndosyaAc.Size = new Size(94, 28);
            btndosyaAc.TabIndex = 0;
            btndosyaAc.Text = "Dosya aç";
            btndosyaAc.UseVisualStyleBackColor = true;
            btndosyaAc.Click += btndosyaAc_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(progressBar2);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(782, 426);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Şifreli Resmi Çöz";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 390);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 8;
            label4.Text = "-";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(7, 356);
            progressBar2.Margin = new Padding(3, 2, 3, 2);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(755, 29);
            progressBar2.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtGizliYazı);
            groupBox4.Controls.Add(btnSifreCoz);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.Location = new Point(400, 16);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(360, 335);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gizlenmiş Metin";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(234, 238);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 16);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(17, 303);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Metin Uzunluğu:";
            // 
            // txtGizliYazı
            // 
            txtGizliYazı.Location = new Point(17, 20);
            txtGizliYazı.Margin = new Padding(3, 2, 3, 2);
            txtGizliYazı.Multiline = true;
            txtGizliYazı.Name = "txtGizliYazı";
            txtGizliYazı.Size = new Size(338, 247);
            txtGizliYazı.TabIndex = 1;
            // 
            // btnSifreCoz
            // 
            btnSifreCoz.Enabled = false;
            btnSifreCoz.Location = new Point(183, 274);
            btnSifreCoz.Margin = new Padding(3, 2, 3, 2);
            btnSifreCoz.Name = "btnSifreCoz";
            btnSifreCoz.Size = new Size(160, 29);
            btnSifreCoz.TabIndex = 0;
            btnSifreCoz.Text = "Şifreli Resmi Çöz";
            btnSifreCoz.UseVisualStyleBackColor = true;
            btnSifreCoz.Click += btnSifreCoz_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(btnSifreliDosyasec);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.Location = new Point(18, 16);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(376, 335);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 303);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Image Size:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(19, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 274);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 2;
            // 
            // btnSifreliDosyasec
            // 
            btnSifreliDosyasec.Location = new Point(272, 274);
            btnSifreliDosyasec.Margin = new Padding(3, 2, 3, 2);
            btnSifreliDosyasec.Name = "btnSifreliDosyasec";
            btnSifreliDosyasec.Size = new Size(94, 29);
            btnSifreliDosyasec.TabIndex = 0;
            btnSifreliDosyasec.Text = "Dosya aç";
            btnSifreliDosyasec.UseVisualStyleBackColor = true;
            btnSifreliDosyasec.Click += btnSifreliDosyasec_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLight;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(772, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 56;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(737, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 55;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // resimSifrele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(809, 496);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "resimSifrele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "resimSifrele";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBsifrelecekResim).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label labelProgress;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtMetinSifrele;
        private Button btnKaydet;
        private Button btnSifrele;
        private ProgressBar progressBar1;
        private GroupBox groupBox1;
        private Label labelImageSize;
        private PictureBox pBsifrelecekResim;
        private TextBox txtSifrelecekResimYolu;
        private Button btndosyaAc;
        private TabPage tabPage2;
        private Label label4;
        private ProgressBar progressBar2;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtGizliYazı;
        private Button btnSifreCoz;
        private GroupBox groupBox3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnSifreliDosyasec;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}