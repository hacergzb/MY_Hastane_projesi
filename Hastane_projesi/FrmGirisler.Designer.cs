namespace Hastane_projesi
{
    partial class FrmGirisler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            BtnHastaGirisi = new Button();
            BtnDoktorGirisi = new Button();
            BtnSekreterGirisi = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnHastaGirisi
            // 
            BtnHastaGirisi.BackgroundImage = (Image)resources.GetObject("BtnHastaGirisi.BackgroundImage");
            BtnHastaGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            BtnHastaGirisi.Location = new Point(4, 22);
            BtnHastaGirisi.Margin = new Padding(4, 3, 4, 3);
            BtnHastaGirisi.Name = "BtnHastaGirisi";
            BtnHastaGirisi.Size = new Size(246, 139);
            BtnHastaGirisi.TabIndex = 0;
            BtnHastaGirisi.UseVisualStyleBackColor = true;
            BtnHastaGirisi.Click += BtnHastaGirisi_Click;
            // 
            // BtnDoktorGirisi
            // 
            BtnDoktorGirisi.BackgroundImage = (Image)resources.GetObject("BtnDoktorGirisi.BackgroundImage");
            BtnDoktorGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            BtnDoktorGirisi.Location = new Point(278, 22);
            BtnDoktorGirisi.Margin = new Padding(4, 3, 4, 3);
            BtnDoktorGirisi.Name = "BtnDoktorGirisi";
            BtnDoktorGirisi.Size = new Size(246, 139);
            BtnDoktorGirisi.TabIndex = 1;
            BtnDoktorGirisi.UseVisualStyleBackColor = true;
            BtnDoktorGirisi.Click += BtnDoktorGirisi_Click;
            // 
            // BtnSekreterGirisi
            // 
            BtnSekreterGirisi.BackgroundImage = (Image)resources.GetObject("BtnSekreterGirisi.BackgroundImage");
            BtnSekreterGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSekreterGirisi.Location = new Point(548, 22);
            BtnSekreterGirisi.Margin = new Padding(4, 3, 4, 3);
            BtnSekreterGirisi.Name = "BtnSekreterGirisi";
            BtnSekreterGirisi.Size = new Size(246, 139);
            BtnSekreterGirisi.TabIndex = 2;
            BtnSekreterGirisi.UseVisualStyleBackColor = true;
            BtnSekreterGirisi.Click += BtnSekreterGirisi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 177);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(367, 177);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 4;
            label2.Text = "Doktor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(637, 177);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(564, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 287);
            label4.Name = "label4";
            label4.Size = new Size(468, 73);
            label4.TabIndex = 7;
            label4.Text = "Sea Green Hospital";
            // 
            // FrmGirisler
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(808, 450);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSekreterGirisi);
            Controls.Add(BtnDoktorGirisi);
            Controls.Add(BtnHastaGirisi);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmGirisler";
            Text = "Sea Green Hospital Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHastaGirisi;
        private Button BtnDoktorGirisi;
        private Button BtnSekreterGirisi;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}