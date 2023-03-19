namespace Hastane_projesi
{
    partial class FrmBilgiDüzenle
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
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            CmbCinsiyet = new ComboBox();
            LblCinsiyet = new Label();
            LblSifre = new Label();
            LblTelefon = new Label();
            LblTCKimlikNo = new Label();
            LblSoyadi = new Label();
            LblAdi = new Label();
            BtnKayitOl = new Button();
            SuspendLayout();
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(179, 201);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(185, 36);
            maskedTextBox2.TabIndex = 25;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(179, 139);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(185, 36);
            maskedTextBox1.TabIndex = 24;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox3
            // 
            textBox3.Location = new Point(179, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 36);
            textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 36);
            textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 36);
            textBox1.TabIndex = 21;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Kadın ", "Erkek" });
            CmbCinsiyet.Location = new Point(179, 321);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(185, 36);
            CmbCinsiyet.TabIndex = 20;
            // 
            // LblCinsiyet
            // 
            LblCinsiyet.AutoSize = true;
            LblCinsiyet.Location = new Point(74, 324);
            LblCinsiyet.Margin = new Padding(4, 0, 4, 0);
            LblCinsiyet.Name = "LblCinsiyet";
            LblCinsiyet.Size = new Size(98, 28);
            LblCinsiyet.TabIndex = 19;
            LblCinsiyet.Text = "Cinsiyet :";
            // 
            // LblSifre
            // 
            LblSifre.AutoSize = true;
            LblSifre.Location = new Point(105, 263);
            LblSifre.Margin = new Padding(4, 0, 4, 0);
            LblSifre.Name = "LblSifre";
            LblSifre.Size = new Size(67, 28);
            LblSifre.TabIndex = 18;
            LblSifre.Text = "Şifre :";
            // 
            // LblTelefon
            // 
            LblTelefon.AutoSize = true;
            LblTelefon.Location = new Point(79, 200);
            LblTelefon.Margin = new Padding(4, 0, 4, 0);
            LblTelefon.Name = "LblTelefon";
            LblTelefon.Size = new Size(93, 28);
            LblTelefon.TabIndex = 17;
            LblTelefon.Text = "Telefon :";
            // 
            // LblTCKimlikNo
            // 
            LblTCKimlikNo.AutoSize = true;
            LblTCKimlikNo.Location = new Point(21, 147);
            LblTCKimlikNo.Margin = new Padding(4, 0, 4, 0);
            LblTCKimlikNo.Name = "LblTCKimlikNo";
            LblTCKimlikNo.Size = new Size(151, 28);
            LblTCKimlikNo.TabIndex = 16;
            LblTCKimlikNo.Text = "T.C Kimlik No :";
            // 
            // LblSoyadi
            // 
            LblSoyadi.AutoSize = true;
            LblSoyadi.Location = new Point(85, 90);
            LblSoyadi.Margin = new Padding(4, 0, 4, 0);
            LblSoyadi.Name = "LblSoyadi";
            LblSoyadi.Size = new Size(87, 28);
            LblSoyadi.TabIndex = 15;
            LblSoyadi.Text = "Soyadı :";
            // 
            // LblAdi
            // 
            LblAdi.AutoSize = true;
            LblAdi.Location = new Point(117, 33);
            LblAdi.Margin = new Padding(4, 0, 4, 0);
            LblAdi.Name = "LblAdi";
            LblAdi.Size = new Size(55, 28);
            LblAdi.TabIndex = 14;
            LblAdi.Text = "Adı :";
            // 
            // BtnKayitOl
            // 
            BtnKayitOl.BackColor = Color.Tan;
            BtnKayitOl.Location = new Point(179, 377);
            BtnKayitOl.Margin = new Padding(4);
            BtnKayitOl.Name = "BtnKayitOl";
            BtnKayitOl.Size = new Size(185, 41);
            BtnKayitOl.TabIndex = 13;
            BtnKayitOl.Text = "Kayıt Ol";
            BtnKayitOl.UseVisualStyleBackColor = false;
            // 
            // FrmBilgiDüzenle
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(545, 489);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(CmbCinsiyet);
            Controls.Add(LblCinsiyet);
            Controls.Add(LblSifre);
            Controls.Add(LblTelefon);
            Controls.Add(LblTCKimlikNo);
            Controls.Add(LblSoyadi);
            Controls.Add(LblAdi);
            Controls.Add(BtnKayitOl);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmBilgiDüzenle";
            Text = "Güncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox CmbCinsiyet;
        private Label LblCinsiyet;
        private Label LblSifre;
        private Label LblTelefon;
        private Label LblTCKimlikNo;
        private Label LblSoyadi;
        private Label LblAdi;
        private Button BtnKayitOl;
    }
}