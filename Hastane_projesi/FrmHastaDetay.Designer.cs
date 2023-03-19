namespace Hastane_projesi
{
    partial class FrmHastaDetay
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
            LnkBilgiDüzenle = new LinkLabel();
            BtnRandevuAl = new Button();
            CmbDoktor = new ComboBox();
            RchSikayet = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            CmbBrans = new ComboBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 211);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgi";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(125, 73);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(119, 24);
            LblAdSoyad.TabIndex = 4;
            LblAdSoyad.Text = "NUUL NULL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 73);
            label3.Name = "label3";
            label3.Size = new Size(102, 24);
            label3.TabIndex = 3;
            label3.Text = "Ad Soyad :";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(93, 40);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(120, 24);
            LblTC.TabIndex = 2;
            LblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(81, 24);
            label1.TabIndex = 1;
            label1.Text = "T.C NO :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LnkBilgiDüzenle);
            groupBox2.Controls.Add(BtnRandevuAl);
            groupBox2.Controls.Add(CmbDoktor);
            groupBox2.Controls.Add(RchSikayet);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(CmbBrans);
            groupBox2.Location = new Point(12, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 310);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Paneli";
            // 
            // LnkBilgiDüzenle
            // 
            LnkBilgiDüzenle.AutoSize = true;
            LnkBilgiDüzenle.Location = new Point(111, 278);
            LnkBilgiDüzenle.Name = "LnkBilgiDüzenle";
            LnkBilgiDüzenle.Size = new Size(165, 24);
            LnkBilgiDüzenle.TabIndex = 8;
            LnkBilgiDüzenle.TabStop = true;
            LnkBilgiDüzenle.Text = "Bilgilerini Düzenle";
            // 
            // BtnRandevuAl
            // 
            BtnRandevuAl.Location = new Point(125, 229);
            BtnRandevuAl.Name = "BtnRandevuAl";
            BtnRandevuAl.Size = new Size(151, 40);
            BtnRandevuAl.TabIndex = 7;
            BtnRandevuAl.Text = "Randevu Al";
            BtnRandevuAl.UseVisualStyleBackColor = true;
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(125, 80);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(151, 32);
            CmbDoktor.TabIndex = 6;
            // 
            // RchSikayet
            // 
            RchSikayet.Location = new Point(125, 123);
            RchSikayet.Name = "RchSikayet";
            RchSikayet.Size = new Size(151, 100);
            RchSikayet.TabIndex = 6;
            RchSikayet.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 40);
            label6.Name = "label6";
            label6.Size = new Size(68, 24);
            label6.TabIndex = 3;
            label6.Text = "Branş :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 88);
            label7.Name = "label7";
            label7.Size = new Size(81, 24);
            label7.TabIndex = 2;
            label7.Text = "Doktor :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 126);
            label8.Name = "label8";
            label8.Size = new Size(85, 24);
            label8.TabIndex = 1;
            label8.Text = "Şikayet :";
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(125, 32);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(151, 32);
            CmbBrans.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(346, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(717, 211);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(711, 180);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(346, 229);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(717, 310);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 28);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(711, 279);
            dataGridView2.TabIndex = 0;
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1100, 540);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmHastaDetay";
            Text = "HastaDetay";
            Load += FrmHastaDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblTC;
        private Label label1;
        private Label LblAdSoyad;
        private Label label3;
        private GroupBox groupBox2;
        private Button BtnRandevuAl;
        private ComboBox CmbDoktor;
        private RichTextBox RchSikayet;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox CmbBrans;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private LinkLabel LnkBilgiDüzenle;
    }
}