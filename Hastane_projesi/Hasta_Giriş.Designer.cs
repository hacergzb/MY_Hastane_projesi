namespace Hastane_projesi
{
    partial class Hasta_Giriş
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
            MskTC = new MaskedTextBox();
            TxtSifre = new TextBox();
            LnkUyeOl = new LinkLabel();
            BtnGirisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 32);
            label1.Name = "label1";
            label1.Size = new Size(314, 50);
            label1.TabIndex = 0;
            label1.Text = "Hasta Giriş Paneli";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 1;
            label2.Text = "T.C Kimlik No: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 180);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 2;
            label3.Text = "Şifre:";
            // 
            // MskTC
            // 
            MskTC.Location = new Point(176, 105);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(228, 36);
            MskTC.TabIndex = 3;
            MskTC.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(176, 172);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(228, 36);
            TxtSifre.TabIndex = 4;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // LnkUyeOl
            // 
            LnkUyeOl.AutoSize = true;
            LnkUyeOl.Location = new Point(176, 257);
            LnkUyeOl.Name = "LnkUyeOl";
            LnkUyeOl.Size = new Size(79, 28);
            LnkUyeOl.TabIndex = 5;
            LnkUyeOl.TabStop = true;
            LnkUyeOl.Text = "Üye Ol";
            LnkUyeOl.LinkClicked += LnkUyeOl_LinkClicked;
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Location = new Point(281, 239);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(123, 46);
            BtnGirisYap.TabIndex = 6;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // Hasta_Giriş
            // 
            AcceptButton = BtnGirisYap;
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(434, 299);
            Controls.Add(BtnGirisYap);
            Controls.Add(LnkUyeOl);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Hasta_Giriş";
            Text = "Hasta_Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox MskTC;
        private TextBox TxtSifre;
        private LinkLabel LnkUyeOl;
        private Button BtnGirisYap;
    }
}