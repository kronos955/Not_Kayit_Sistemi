namespace WindowsFormsApp1
{
    partial class FrmOgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OgrAdSoyad = new System.Windows.Forms.Label();
            this.OgrNumara = new System.Windows.Forms.Label();
            this.OgrSinav1 = new System.Windows.Forms.Label();
            this.OgrSinav2 = new System.Windows.Forms.Label();
            this.OgrSinav3 = new System.Windows.Forms.Label();
            this.OgrOrtalama = new System.Windows.Forms.Label();
            this.OgrDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(277, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(295, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numara:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "1. Sınav:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "2. Sınav:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "3. Sınav:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ortalama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Durum:";
            // 
            // OgrAdSoyad
            // 
            this.OgrAdSoyad.AutoSize = true;
            this.OgrAdSoyad.Location = new System.Drawing.Point(388, 31);
            this.OgrAdSoyad.Name = "OgrAdSoyad";
            this.OgrAdSoyad.Size = new System.Drawing.Size(62, 25);
            this.OgrAdSoyad.TabIndex = 8;
            this.OgrAdSoyad.Text = "NULL";
            // 
            // OgrNumara
            // 
            this.OgrNumara.AutoSize = true;
            this.OgrNumara.Location = new System.Drawing.Point(388, 72);
            this.OgrNumara.Name = "OgrNumara";
            this.OgrNumara.Size = new System.Drawing.Size(56, 25);
            this.OgrNumara.TabIndex = 9;
            this.OgrNumara.Text = "0000";
            // 
            // OgrSinav1
            // 
            this.OgrSinav1.AutoSize = true;
            this.OgrSinav1.Location = new System.Drawing.Point(111, 191);
            this.OgrSinav1.Name = "OgrSinav1";
            this.OgrSinav1.Size = new System.Drawing.Size(34, 25);
            this.OgrSinav1.TabIndex = 10;
            this.OgrSinav1.Text = "00";
            // 
            // OgrSinav2
            // 
            this.OgrSinav2.AutoSize = true;
            this.OgrSinav2.Location = new System.Drawing.Point(110, 226);
            this.OgrSinav2.Name = "OgrSinav2";
            this.OgrSinav2.Size = new System.Drawing.Size(34, 25);
            this.OgrSinav2.TabIndex = 11;
            this.OgrSinav2.Text = "00";
            // 
            // OgrSinav3
            // 
            this.OgrSinav3.AutoSize = true;
            this.OgrSinav3.Location = new System.Drawing.Point(110, 261);
            this.OgrSinav3.Name = "OgrSinav3";
            this.OgrSinav3.Size = new System.Drawing.Size(34, 25);
            this.OgrSinav3.TabIndex = 12;
            this.OgrSinav3.Text = "00";
            // 
            // OgrOrtalama
            // 
            this.OgrOrtalama.AutoSize = true;
            this.OgrOrtalama.Location = new System.Drawing.Point(377, 191);
            this.OgrOrtalama.Name = "OgrOrtalama";
            this.OgrOrtalama.Size = new System.Drawing.Size(34, 25);
            this.OgrOrtalama.TabIndex = 13;
            this.OgrOrtalama.Text = "00";
            // 
            // OgrDurum
            // 
            this.OgrDurum.AutoSize = true;
            this.OgrDurum.Location = new System.Drawing.Point(377, 226);
            this.OgrDurum.Name = "OgrDurum";
            this.OgrDurum.Size = new System.Drawing.Size(62, 25);
            this.OgrDurum.TabIndex = 14;
            this.OgrDurum.Text = "NULL";
//            this.OgrDurum.Click += new System.EventHandler(this.OgrDurum_Click);
            // 
            // FrmOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 315);
            this.Controls.Add(this.OgrDurum);
            this.Controls.Add(this.OgrOrtalama);
            this.Controls.Add(this.OgrSinav3);
            this.Controls.Add(this.OgrSinav2);
            this.Controls.Add(this.OgrSinav1);
            this.Controls.Add(this.OgrNumara);
            this.Controls.Add(this.OgrAdSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmOgrenciGiris";
            this.Text = "FrmOgrenciGiris";
            this.Load += new System.EventHandler(this.FrmOgrenciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label OgrAdSoyad;
        private System.Windows.Forms.Label OgrNumara;
        private System.Windows.Forms.Label OgrSinav1;
        private System.Windows.Forms.Label OgrSinav2;
        private System.Windows.Forms.Label OgrSinav3;
        private System.Windows.Forms.Label OgrOrtalama;
        private System.Windows.Forms.Label OgrDurum;
    }
}