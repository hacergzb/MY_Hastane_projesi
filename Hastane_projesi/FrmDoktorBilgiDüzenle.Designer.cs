namespace Hastane_projesi
{
    partial class FrmDoktorBilgiDüzenle
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
            MskTC = new MaskedTextBox();
            TxtSoyad = new TextBox();
            TxtAd = new TextBox();
            LblTCKimlikNo = new Label();
            LblSoyadi = new Label();
            LblAdi = new Label();
            TxtSifre = new TextBox();
            LblSifre = new Label();
            label1 = new Label();
            BtnGirisYap = new Button();
            CmbBrans = new ComboBox();
            SuspendLayout();
            // 
            // MskTC
            // 
            MskTC.Location = new Point(230, 194);
            MskTC.Margin = new Padding(5, 5, 5, 5);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(298, 38);
            MskTC.TabIndex = 30;
            MskTC.ValidatingType = typeof(int);
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(230, 106);
            TxtSoyad.Margin = new Padding(5, 5, 5, 5);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(298, 38);
            TxtSoyad.TabIndex = 29;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(230, 36);
            TxtAd.Margin = new Padding(5, 5, 5, 5);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(298, 38);
            TxtAd.TabIndex = 28;
            // 
            // LblTCKimlikNo
            // 
            LblTCKimlikNo.AutoSize = true;
            LblTCKimlikNo.Location = new Point(30, 197);
            LblTCKimlikNo.Margin = new Padding(6, 0, 6, 0);
            LblTCKimlikNo.Name = "LblTCKimlikNo";
            LblTCKimlikNo.Size = new Size(160, 31);
            LblTCKimlikNo.TabIndex = 27;
            LblTCKimlikNo.Text = "T.C Kimlik No :";
            // 
            // LblSoyadi
            // 
            LblSoyadi.AutoSize = true;
            LblSoyadi.Location = new Point(97, 109);
            LblSoyadi.Margin = new Padding(6, 0, 6, 0);
            LblSoyadi.Name = "LblSoyadi";
            LblSoyadi.Size = new Size(93, 31);
            LblSoyadi.TabIndex = 26;
            LblSoyadi.Text = "Soyadı :";
            // 
            // LblAdi
            // 
            LblAdi.AutoSize = true;
            LblAdi.Location = new Point(130, 39);
            LblAdi.Margin = new Padding(6, 0, 6, 0);
            LblAdi.Name = "LblAdi";
            LblAdi.Size = new Size(60, 31);
            LblAdi.TabIndex = 25;
            LblAdi.Text = "Adı :";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(230, 344);
            TxtSifre.Margin = new Padding(5, 5, 5, 5);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(298, 38);
            TxtSifre.TabIndex = 32;
            // 
            // LblSifre
            // 
            LblSifre.AutoSize = true;
            LblSifre.Location = new Point(120, 344);
            LblSifre.Margin = new Padding(6, 0, 6, 0);
            LblSifre.Name = "LblSifre";
            LblSifre.Size = new Size(70, 31);
            LblSifre.TabIndex = 31;
            LblSifre.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 277);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 31);
            label1.TabIndex = 33;
            label1.Text = "Branş :";
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.BackColor = Color.Tan;
            BtnGirisYap.Location = new Point(231, 406);
            BtnGirisYap.Margin = new Padding(4);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(298, 61);
            BtnGirisYap.TabIndex = 35;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = false;
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(230, 269);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(298, 39);
            CmbBrans.TabIndex = 36;
            // 
            // FrmDoktorBilgiDüzenle
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(693, 479);
            Controls.Add(CmbBrans);
            Controls.Add(BtnGirisYap);
            Controls.Add(label1);
            Controls.Add(TxtSifre);
            Controls.Add(LblSifre);
            Controls.Add(MskTC);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(LblTCKimlikNo);
            Controls.Add(LblSoyadi);
            Controls.Add(LblAdi);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmDoktorBilgiDüzenle";
            Text = "FrmDoktorBilgiDüzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox MskTC;
        private TextBox TxtSoyad;
        private TextBox TxtAd;
        private Label LblTCKimlikNo;
        private Label LblSoyadi;
        private Label LblAdi;
        private TextBox TxtSifre;
        private Label LblSifre;
        private Label label1;
        private Button BtnGirisYap;
        private ComboBox CmbBrans;
    }
}