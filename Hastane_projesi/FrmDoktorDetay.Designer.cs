namespace Hastane_projesi
{
    partial class FrmDoktorDetay
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
            LblAdSoyad = new Label();
            label3 = new Label();
            LblTC = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            RchSikayet = new RichTextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            BtnCikis = new Button();
            BtnDuyurular = new Button();
            BtnGuncelle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 151);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgi";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(151, 87);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(83, 20);
            LblAdSoyad.TabIndex = 3;
            LblAdSoyad.Text = "NULL NULL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 87);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Adı Soyadı :";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(151, 30);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(97, 20);
            LblTC.TabIndex = 1;
            LblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "T.C Kimlik No :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RchSikayet);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(1, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 289);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detayı";
            // 
            // RchSikayet
            // 
            RchSikayet.Location = new Point(12, 59);
            RchSikayet.Name = "RchSikayet";
            RchSikayet.Size = new Size(304, 224);
            RchSikayet.TabIndex = 4;
            RchSikayet.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 36);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 3;
            label5.Text = "Şikayet :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(329, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(470, 597);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(464, 571);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnCikis);
            groupBox4.Controls.Add(BtnDuyurular);
            groupBox4.Controls.Add(BtnGuncelle);
            groupBox4.Location = new Point(1, 455);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(322, 145);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hızlı Erişim";
            // 
            // BtnCikis
            // 
            BtnCikis.Location = new Point(159, 84);
            BtnCikis.Name = "BtnCikis";
            BtnCikis.Size = new Size(150, 36);
            BtnCikis.TabIndex = 3;
            BtnCikis.Text = "Çıkış";
            BtnCikis.UseVisualStyleBackColor = true;
            // 
            // BtnDuyurular
            // 
            BtnDuyurular.Location = new Point(159, 26);
            BtnDuyurular.Name = "BtnDuyurular";
            BtnDuyurular.Size = new Size(150, 36);
            BtnDuyurular.TabIndex = 1;
            BtnDuyurular.Text = "Duyurular";
            BtnDuyurular.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(3, 26);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(150, 36);
            BtnGuncelle.TabIndex = 0;
            BtnGuncelle.Text = "Bilgi Düzenle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 599);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmDoktorDetay";
            Text = "FrmDoktorDetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private Label label3;
        private Label LblTC;
        private Label label1;
        private GroupBox groupBox2;
        private RichTextBox RchSikayet;
        private Label label5;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private Button BtnCikis;
        private Button BtnDuyurular;
        private Button BtnGuncelle;
    }
}