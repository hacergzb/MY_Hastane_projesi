namespace Hastane_projesi
{
    partial class FrmSekreterDetay
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            LblTC = new Label();
            LblAdSoyad = new Label();
            groupBox2 = new GroupBox();
            RchDuyuru = new RichTextBox();
            BtnDuyuruOlustur = new Button();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Txtİd = new TextBox();
            MskTarih = new MaskedTextBox();
            MskSaat = new MaskedTextBox();
            CmbBrans = new ComboBox();
            CmbDoktor = new ComboBox();
            MskTC = new MaskedTextBox();
            ChkDurum = new CheckBox();
            BtnKaydet = new Button();
            BtnGuncelle = new Button();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox6 = new GroupBox();
            BtnDoktorPaneli = new Button();
            BtnBransPaneli = new Button();
            BtnRandevuListesi = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sekreter Bilgi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "T.C No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 67);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad :";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(100, 23);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(97, 20);
            LblTC.TabIndex = 2;
            LblTC.Text = "00000000000";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(100, 67);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(83, 20);
            LblAdSoyad.TabIndex = 3;
            LblAdSoyad.Text = "NULL NULL";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RchDuyuru);
            groupBox2.Location = new Point(12, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 252);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Oluştur";
            // 
            // RchDuyuru
            // 
            RchDuyuru.Location = new Point(6, 26);
            RchDuyuru.Name = "RchDuyuru";
            RchDuyuru.Size = new Size(238, 164);
            RchDuyuru.TabIndex = 0;
            RchDuyuru.Text = "";
            // 
            // BtnDuyuruOlustur
            // 
            BtnDuyuruOlustur.Location = new Point(18, 352);
            BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            BtnDuyuruOlustur.Size = new Size(238, 43);
            BtnDuyuruOlustur.TabIndex = 2;
            BtnDuyuruOlustur.Text = "Oluştur";
            BtnDuyuruOlustur.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnGuncelle);
            groupBox3.Controls.Add(BtnKaydet);
            groupBox3.Controls.Add(ChkDurum);
            groupBox3.Controls.Add(MskTC);
            groupBox3.Controls.Add(CmbDoktor);
            groupBox3.Controls.Add(CmbBrans);
            groupBox3.Controls.Add(MskSaat);
            groupBox3.Controls.Add(MskTarih);
            groupBox3.Controls.Add(Txtİd);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(268, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 396);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Paneli";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 35);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 0;
            label5.Text = "İd :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 73);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 1;
            label6.Text = "Tarih :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 111);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 2;
            label7.Text = "Saat :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 150);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 3;
            label8.Text = "Branş :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 188);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 4;
            label9.Text = "Doktor :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 228);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 5;
            label10.Text = "Hasta T.C :";
            // 
            // Txtİd
            // 
            Txtİd.Location = new Point(88, 29);
            Txtİd.Name = "Txtİd";
            Txtİd.Size = new Size(151, 27);
            Txtİd.TabIndex = 7;
            // 
            // MskTarih
            // 
            MskTarih.AccessibleDescription = "";
            MskTarih.Location = new Point(88, 66);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new Size(151, 27);
            MskTarih.TabIndex = 8;
            MskTarih.ValidatingType = typeof(DateTime);
            // 
            // MskSaat
            // 
            MskSaat.Location = new Point(88, 108);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new Size(151, 27);
            MskSaat.TabIndex = 9;
            MskSaat.ValidatingType = typeof(DateTime);
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(88, 147);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(151, 28);
            CmbBrans.TabIndex = 10;
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(88, 181);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(151, 28);
            CmbDoktor.TabIndex = 11;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(88, 221);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(151, 27);
            MskTC.TabIndex = 12;
            MskTC.ValidatingType = typeof(int);
            // 
            // ChkDurum
            // 
            ChkDurum.AutoSize = true;
            ChkDurum.Location = new Point(90, 253);
            ChkDurum.Name = "ChkDurum";
            ChkDurum.Size = new Size(76, 24);
            ChkDurum.TabIndex = 13;
            ChkDurum.Text = "Durum";
            ChkDurum.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(6, 283);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(238, 43);
            BtnKaydet.TabIndex = 14;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(6, 337);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(238, 43);
            BtnGuncelle.TabIndex = 15;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(524, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(307, 218);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Location = new Point(524, 246);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(307, 310);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(301, 284);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnRandevuListesi);
            groupBox6.Controls.Add(BtnBransPaneli);
            groupBox6.Controls.Add(BtnDoktorPaneli);
            groupBox6.Location = new Point(12, 431);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(506, 125);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "groupBox6";
            // 
            // BtnDoktorPaneli
            // 
            BtnDoktorPaneli.Location = new Point(6, 16);
            BtnDoktorPaneli.Name = "BtnDoktorPaneli";
            BtnDoktorPaneli.Size = new Size(238, 43);
            BtnDoktorPaneli.TabIndex = 3;
            BtnDoktorPaneli.Text = "Doktor Paneli";
            BtnDoktorPaneli.UseVisualStyleBackColor = true;
            // 
            // BtnBransPaneli
            // 
            BtnBransPaneli.Location = new Point(250, 16);
            BtnBransPaneli.Name = "BtnBransPaneli";
            BtnBransPaneli.Size = new Size(238, 43);
            BtnBransPaneli.TabIndex = 4;
            BtnBransPaneli.Text = "Branş Paneli";
            BtnBransPaneli.UseVisualStyleBackColor = true;
            // 
            // BtnRandevuListesi
            // 
            BtnRandevuListesi.Location = new Point(125, 65);
            BtnRandevuListesi.Name = "BtnRandevuListesi";
            BtnRandevuListesi.Size = new Size(238, 43);
            BtnRandevuListesi.TabIndex = 5;
            BtnRandevuListesi.Text = "Randevu Listesi";
            BtnRandevuListesi.UseVisualStyleBackColor = true;
            // 
            // FrmSekreterDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(843, 568);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(BtnDuyuruOlustur);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSekreterDetay";
            Text = "FrmSekreterDetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private Label LblTC;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RichTextBox RchDuyuru;
        private Button BtnDuyuruOlustur;
        private GroupBox groupBox3;
        private Button BtnGuncelle;
        private Button BtnKaydet;
        private CheckBox ChkDurum;
        private MaskedTextBox MskTC;
        private ComboBox CmbDoktor;
        private ComboBox CmbBrans;
        private MaskedTextBox MskSaat;
        private MaskedTextBox MskTarih;
        private TextBox Txtİd;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        private Button BtnRandevuListesi;
        private Button BtnBransPaneli;
        private Button BtnDoktorPaneli;
    }
}