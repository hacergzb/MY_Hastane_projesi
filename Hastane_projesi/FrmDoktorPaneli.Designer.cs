namespace Hastane_projesi
{
    partial class FrmDoktorPaneli
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            MskTCKimlik = new MaskedTextBox();
            TxtAd = new TextBox();
            TxtSoyad = new TextBox();
            TxtSifre = new TextBox();
            CmbBrans = new ComboBox();
            dataGridView1 = new DataGridView();
            BtnEkle = new Button();
            BtnSil = new Button();
            BtnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 36);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 31);
            label1.TabIndex = 0;
            label1.Text = "Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 126);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 31);
            label2.TabIndex = 1;
            label2.Text = "Soyadı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 195);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 31);
            label3.TabIndex = 2;
            label3.Text = "T.C Kimlik No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 262);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 31);
            label4.TabIndex = 3;
            label4.Text = "Branş :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 333);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 31);
            label5.TabIndex = 4;
            label5.Text = "Şifre :";
            // 
            // MskTCKimlik
            // 
            MskTCKimlik.Location = new Point(239, 191);
            MskTCKimlik.Margin = new Padding(5, 5, 5, 5);
            MskTCKimlik.Mask = "00000000000";
            MskTCKimlik.Name = "MskTCKimlik";
            MskTCKimlik.Size = new Size(201, 38);
            MskTCKimlik.TabIndex = 5;
            MskTCKimlik.ValidatingType = typeof(int);
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(239, 36);
            TxtAd.Margin = new Padding(5, 5, 5, 5);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(201, 38);
            TxtAd.TabIndex = 6;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(239, 121);
            TxtSoyad.Margin = new Padding(5, 5, 5, 5);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(201, 38);
            TxtSoyad.TabIndex = 7;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(239, 326);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(201, 38);
            TxtSifre.TabIndex = 8;
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(239, 262);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(201, 39);
            CmbBrans.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(472, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(332, 448);
            dataGridView1.TabIndex = 10;
            // 
            // BtnEkle
            // 
            BtnEkle.BackColor = Color.FromArgb(192, 192, 0);
            BtnEkle.Location = new Point(239, 385);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(91, 49);
            BtnEkle.TabIndex = 11;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = false;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.FromArgb(192, 0, 0);
            BtnSil.Location = new Point(349, 385);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(91, 49);
            BtnSil.TabIndex = 12;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.FromArgb(128, 128, 255);
            BtnGuncelle.Location = new Point(239, 435);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(201, 49);
            BtnGuncelle.TabIndex = 13;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            // 
            // FrmDoktorPaneli
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 496);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(CmbBrans);
            Controls.Add(TxtSifre);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(MskTCKimlik);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmDoktorPaneli";
            Text = "FrmDoktorPaneli";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox MskTCKimlik;
        private TextBox TxtAd;
        private TextBox TxtSoyad;
        private TextBox TxtSifre;
        private ComboBox CmbBrans;
        private DataGridView dataGridView1;
        private Button BtnEkle;
        private Button BtnSil;
        private Button BtnGuncelle;
    }
}