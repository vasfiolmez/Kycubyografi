namespace Kycubyografi
{
    partial class siteVeriCekme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siteVeriCekme));
            listBox4 = new ListBox();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            buttonKaydet = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            textbox_kaynaksite = new TextBox();
            label10 = new Label();
            textBox_hedefsite = new TextBox();
            search = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(581, 412);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(293, 154);
            listBox4.TabIndex = 48;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(580, 320);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(294, 19);
            listBox3.TabIndex = 45;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(580, 239);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(294, 19);
            listBox2.TabIndex = 46;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(580, 167);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(294, 19);
            listBox1.TabIndex = 47;
            // 
            // buttonKaydet
            // 
            buttonKaydet.BackColor = Color.RosyBrown;
            buttonKaydet.Cursor = Cursors.Hand;
            buttonKaydet.Font = new Font("Times New Roman", 18F);
            buttonKaydet.ForeColor = SystemColors.ControlLightLight;
            buttonKaydet.Location = new Point(581, 584);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(296, 44);
            buttonKaydet.TabIndex = 44;
            buttonKaydet.Text = "Verileri Kaydet";
            buttonKaydet.UseVisualStyleBackColor = false;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F);
            label4.Location = new Point(577, 375);
            label4.Name = "label4";
            label4.Size = new Size(189, 21);
            label4.TabIndex = 40;
            label4.Text = "Aranan Sitelerin Listesi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(576, 291);
            label3.Name = "label3";
            label3.Size = new Size(278, 21);
            label3.TabIndex = 41;
            label3.Text = "Site içinde bulunan Twitter adresleri:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(575, 215);
            label2.Name = "label2";
            label2.Size = new Size(299, 21);
            label2.TabIndex = 42;
            label2.Text = "Site içinde bulunan Instagram adresleri:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F);
            label1.Location = new Point(576, 143);
            label1.Name = "label1";
            label1.Size = new Size(301, 21);
            label1.TabIndex = 43;
            label1.Text = "Site içinde bulunan Facebook adresleri:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Font = new Font("Times New Roman", 14.25F);
            groupBox1.Location = new Point(35, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 503);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Domain Bilgileri";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 9.75F);
            richTextBox1.Location = new Point(10, 21);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(501, 476);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // textbox_kaynaksite
            // 
            textbox_kaynaksite.Font = new Font("Lucida Sans", 9.75F);
            textbox_kaynaksite.Location = new Point(581, 91);
            textbox_kaynaksite.Name = "textbox_kaynaksite";
            textbox_kaynaksite.ReadOnly = true;
            textbox_kaynaksite.Size = new Size(254, 23);
            textbox_kaynaksite.TabIndex = 38;
            textbox_kaynaksite.Text = "https://www.whois.com/whois/";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F);
            label10.Location = new Point(576, 61);
            label10.Name = "label10";
            label10.Size = new Size(108, 21);
            label10.TabIndex = 37;
            label10.Text = "Kaynak Site :";
            // 
            // textBox_hedefsite
            // 
            textBox_hedefsite.Font = new Font("Lucida Sans", 12F);
            textBox_hedefsite.Location = new Point(35, 50);
            textBox_hedefsite.Name = "textBox_hedefsite";
            textBox_hedefsite.Size = new Size(523, 26);
            textBox_hedefsite.TabIndex = 36;
            // 
            // search
            // 
            search.BackColor = Color.RosyBrown;
            search.Cursor = Cursors.Hand;
            search.FlatStyle = FlatStyle.Popup;
            search.Font = new Font("Times New Roman", 14.25F);
            search.ForeColor = SystemColors.ControlLightLight;
            search.Location = new Point(35, 82);
            search.Name = "search";
            search.Size = new Size(523, 34);
            search.TabIndex = 35;
            search.Text = "Başlat";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLight;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(861, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(816, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // siteVeriCekme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(912, 656);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(buttonKaydet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(textbox_kaynaksite);
            Controls.Add(label10);
            Controls.Add(textBox_hedefsite);
            Controls.Add(search);
            FormBorderStyle = FormBorderStyle.None;
            Name = "siteVeriCekme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "siteVeriCekme";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox4;
        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox listBox1;
        private Button buttonKaydet;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private TextBox textbox_kaynaksite;
        private Label label10;
        private TextBox textBox_hedefsite;
        private Button search;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private SaveFileDialog saveFileDialog1;
    }
}