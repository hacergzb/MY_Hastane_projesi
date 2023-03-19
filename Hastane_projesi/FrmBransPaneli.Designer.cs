namespace Hastane_projesi
{
    partial class FrmBransPaneli
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
            dataGridView1 = new DataGridView();
            TxtBrans = new TextBox();
            Txtİd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(369, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(388, 264);
            dataGridView1.TabIndex = 15;
            // 
            // TxtBrans
            // 
            TxtBrans.Location = new Point(151, 142);
            TxtBrans.Margin = new Padding(5);
            TxtBrans.Name = "TxtBrans";
            TxtBrans.Size = new Size(201, 38);
            TxtBrans.TabIndex = 14;
            // 
            // Txtİd
            // 
            Txtİd.Location = new Point(151, 57);
            Txtİd.Margin = new Padding(5);
            Txtİd.Name = "Txtİd";
            Txtİd.Size = new Size(201, 38);
            Txtİd.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 147);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 31);
            label2.TabIndex = 12;
            label2.Text = "Branş Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 57);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 31);
            label1.TabIndex = 11;
            label1.Text = "Branş İd :";
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.FromArgb(128, 128, 255);
            BtnGuncelle.Location = new Point(102, 270);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(201, 49);
            BtnGuncelle.TabIndex = 18;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.FromArgb(192, 0, 0);
            BtnSil.Location = new Point(212, 220);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(91, 49);
            BtnSil.TabIndex = 17;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            // 
            // BtnEkle
            // 
            BtnEkle.BackColor = Color.FromArgb(192, 192, 0);
            BtnEkle.Location = new Point(102, 220);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(91, 49);
            BtnEkle.TabIndex = 16;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = false;
            // 
            // FrmBransPaneli
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 610);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(TxtBrans);
            Controls.Add(Txtİd);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmBransPaneli";
            Text = "FrmBransPaneli";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox TxtBrans;
        private TextBox Txtİd;
        private Label label2;
        private Label label1;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnEkle;
    }
}