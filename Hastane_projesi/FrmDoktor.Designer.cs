namespace Hastane_projesi
{
    partial class FrmDoktor
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
            BtnGirisYap = new Button();
            TxtSifre = new TextBox();
            MskTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.BackColor = Color.MistyRose;
            BtnGirisYap.Location = new Point(282, 254);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(123, 46);
            BtnGirisYap.TabIndex = 12;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = false;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(177, 187);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(228, 32);
            TxtSifre.TabIndex = 11;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(177, 120);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(228, 32);
            MskTC.TabIndex = 10;
            MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 195);
            label3.Name = "label3";
            label3.Size = new Size(54, 24);
            label3.TabIndex = 9;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 128);
            label2.Name = "label2";
            label2.Size = new Size(132, 24);
            label2.TabIndex = 8;
            label2.Text = "T.C Kimlik No: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(448, 67);
            label1.TabIndex = 7;
            label1.Text = "Doktor Giriş Paneli";
            label1.Click += label1_Click;
            // 
            // FrmDoktor
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(520, 344);
            Controls.Add(BtnGirisYap);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmDoktor";
            Text = "FrmDoktorGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGirisYap;
        private TextBox TxtSifre;
        private MaskedTextBox MskTC;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}