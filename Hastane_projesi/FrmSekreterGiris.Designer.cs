namespace Hastane_projesi
{
    partial class FrmSekreterGiris
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
            BtnGirisYap.Location = new Point(300, 269);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(123, 46);
            BtnGirisYap.TabIndex = 18;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = false;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(195, 202);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(228, 27);
            TxtSifre.TabIndex = 17;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(195, 135);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(228, 27);
            MskTC.TabIndex = 16;
            MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 210);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 15;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 143);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 14;
            label2.Text = "T.C Kimlik No: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(31, 42);
            label1.Name = "label1";
            label1.Size = new Size(472, 67);
            label1.TabIndex = 13;
            label1.Text = "Sekreter Giriş Paneli";
            // 
            // FrmSekreterGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(510, 380);
            Controls.Add(BtnGirisYap);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSekreterGiris";
            Text = "FrmSekreterGiriş";
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