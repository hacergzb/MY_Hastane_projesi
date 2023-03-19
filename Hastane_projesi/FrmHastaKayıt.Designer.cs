namespace Hastane_projesi
{
    partial class FrmHastaKayıt
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
            BtnKayitOl = new Button();
            LblAdi = new Label();
            LblSoyadi = new Label();
            LblTCKimlikNo = new Label();
            LblTelefon = new Label();
            LblSifre = new Label();
            LblCinsiyet = new Label();
            CmbCinsiyet = new ComboBox();
            TxtAd = new TextBox();
            TxtSoyad = new TextBox();
            TxtSifre = new TextBox();
            MskTC = new MaskedTextBox();
            MskTelefon = new MaskedTextBox();
            SuspendLayout();
            // 
            // BtnKayitOl
            // 
            BtnKayitOl.BackColor = Color.PaleGreen;
            BtnKayitOl.Location = new Point(171, 388);
            BtnKayitOl.Margin = new Padding(4);
            BtnKayitOl.Name = "BtnKayitOl";
            BtnKayitOl.Size = new Size(185, 41);
            BtnKayitOl.TabIndex = 7;
            BtnKayitOl.Text = "Kayıt Ol";
            BtnKayitOl.UseVisualStyleBackColor = false;
            BtnKayitOl.Click += BtnKayitOl_Click;
            // 
            // LblAdi
            // 
            LblAdi.AutoSize = true;
            LblAdi.Location = new Point(109, 44);
            LblAdi.Margin = new Padding(4, 0, 4, 0);
            LblAdi.Name = "LblAdi";
            LblAdi.Size = new Size(55, 28);
            LblAdi.TabIndex = 1;
            LblAdi.Text = "Adı :";
            // 
            // LblSoyadi
            // 
            LblSoyadi.AutoSize = true;
            LblSoyadi.Location = new Point(77, 101);
            LblSoyadi.Margin = new Padding(4, 0, 4, 0);
            LblSoyadi.Name = "LblSoyadi";
            LblSoyadi.Size = new Size(87, 28);
            LblSoyadi.TabIndex = 2;
            LblSoyadi.Text = "Soyadı :";
            // 
            // LblTCKimlikNo
            // 
            LblTCKimlikNo.AutoSize = true;
            LblTCKimlikNo.Location = new Point(13, 158);
            LblTCKimlikNo.Margin = new Padding(4, 0, 4, 0);
            LblTCKimlikNo.Name = "LblTCKimlikNo";
            LblTCKimlikNo.Size = new Size(151, 28);
            LblTCKimlikNo.TabIndex = 3;
            LblTCKimlikNo.Text = "T.C Kimlik No :";
            // 
            // LblTelefon
            // 
            LblTelefon.AutoSize = true;
            LblTelefon.Location = new Point(71, 211);
            LblTelefon.Margin = new Padding(4, 0, 4, 0);
            LblTelefon.Name = "LblTelefon";
            LblTelefon.Size = new Size(93, 28);
            LblTelefon.TabIndex = 4;
            LblTelefon.Text = "Telefon :";
            // 
            // LblSifre
            // 
            LblSifre.AutoSize = true;
            LblSifre.Location = new Point(97, 274);
            LblSifre.Margin = new Padding(4, 0, 4, 0);
            LblSifre.Name = "LblSifre";
            LblSifre.Size = new Size(67, 28);
            LblSifre.TabIndex = 5;
            LblSifre.Text = "Şifre :";
            // 
            // LblCinsiyet
            // 
            LblCinsiyet.AutoSize = true;
            LblCinsiyet.Location = new Point(66, 335);
            LblCinsiyet.Margin = new Padding(4, 0, 4, 0);
            LblCinsiyet.Name = "LblCinsiyet";
            LblCinsiyet.Size = new Size(98, 28);
            LblCinsiyet.TabIndex = 6;
            LblCinsiyet.Text = "Cinsiyet :";
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Kadın ", "Erkek" });
            CmbCinsiyet.Location = new Point(171, 332);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(185, 36);
            CmbCinsiyet.TabIndex = 6;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(171, 36);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(185, 36);
            TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(171, 93);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(185, 36);
            TxtSoyad.TabIndex = 2;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(171, 271);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(185, 36);
            TxtSifre.TabIndex = 5;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(171, 150);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(185, 36);
            MskTC.TabIndex = 3;
            MskTC.ValidatingType = typeof(int);
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(171, 212);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(185, 36);
            MskTelefon.TabIndex = 4;
            // 
            // FrmHastaKayıt
            // 
            AcceptButton = BtnKayitOl;
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(682, 525);
            Controls.Add(MskTelefon);
            Controls.Add(MskTC);
            Controls.Add(TxtSifre);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(CmbCinsiyet);
            Controls.Add(LblCinsiyet);
            Controls.Add(LblSifre);
            Controls.Add(LblTelefon);
            Controls.Add(LblTCKimlikNo);
            Controls.Add(LblSoyadi);
            Controls.Add(LblAdi);
            Controls.Add(BtnKayitOl);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmHastaKayıt";
            Text = "Hasta Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnKayitOl;
        private Label LblAdi;
        private Label LblSoyadi;
        private Label LblTCKimlikNo;
        private Label LblTelefon;
        private Label LblSifre;
        private Label LblCinsiyet;
        private ComboBox CmbCinsiyet;
        private TextBox TxtAd;
        private TextBox TxtSoyad;
        private TextBox TxtSifre;
        private MaskedTextBox MskTC;
        private MaskedTextBox MskTelefon;
    }
}