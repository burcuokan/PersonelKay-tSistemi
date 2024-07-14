namespace PersonelKayitSistemi
{
    partial class FrmPersonelKayıt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelKayıt));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.TxtMaas = new System.Windows.Forms.TextBox();
            this.TxtSehir = new System.Windows.Forms.TextBox();
            this.TxtMeslek = new System.Windows.Forms.TextBox();
            this.TxtPersonelAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtPersonelid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGrafikler = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btnİstatistik = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDurum);
            this.groupBox1.Controls.Add(this.TxtMaas);
            this.groupBox1.Controls.Add(this.TxtSehir);
            this.groupBox1.Controls.Add(this.TxtMeslek);
            this.groupBox1.Controls.Add(this.TxtPersonelAd);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtPersonelid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(313, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(121, 229);
            this.TxtDurum.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(165, 31);
            this.TxtDurum.TabIndex = 6;
            // 
            // TxtMaas
            // 
            this.TxtMaas.Location = new System.Drawing.Point(121, 192);
            this.TxtMaas.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMaas.Name = "TxtMaas";
            this.TxtMaas.Size = new System.Drawing.Size(165, 31);
            this.TxtMaas.TabIndex = 5;
            // 
            // TxtSehir
            // 
            this.TxtSehir.Location = new System.Drawing.Point(121, 154);
            this.TxtSehir.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(165, 31);
            this.TxtSehir.TabIndex = 4;
            // 
            // TxtMeslek
            // 
            this.TxtMeslek.Location = new System.Drawing.Point(121, 268);
            this.TxtMeslek.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMeslek.Name = "TxtMeslek";
            this.TxtMeslek.Size = new System.Drawing.Size(165, 31);
            this.TxtMeslek.TabIndex = 7;
            // 
            // TxtPersonelAd
            // 
            this.TxtPersonelAd.Location = new System.Drawing.Point(121, 77);
            this.TxtPersonelAd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPersonelAd.Name = "TxtPersonelAd";
            this.TxtPersonelAd.Size = new System.Drawing.Size(165, 31);
            this.TxtPersonelAd.TabIndex = 2;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(121, 116);
            this.TxtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(165, 31);
            this.TxtSoyad.TabIndex = 3;
            // 
            // TxtPersonelid
            // 
            this.TxtPersonelid.Location = new System.Drawing.Point(121, 38);
            this.TxtPersonelid.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPersonelid.Name = "TxtPersonelid";
            this.TxtPersonelid.Size = new System.Drawing.Size(165, 31);
            this.TxtPersonelid.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Meslek:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGrafikler);
            this.groupBox2.Controls.Add(this.Btnİstatistik);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.BtnKaydet);
            this.groupBox2.Controls.Add(this.BtnListele);
            this.groupBox2.Location = new System.Drawing.Point(347, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(281, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // BtnGrafikler
            // 
            this.BtnGrafikler.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnGrafikler.ImageIndex = 3;
            this.BtnGrafikler.ImageList = this.ımageList1;
            this.BtnGrafikler.Location = new System.Drawing.Point(39, 235);
            this.BtnGrafikler.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGrafikler.Name = "BtnGrafikler";
            this.BtnGrafikler.Size = new System.Drawing.Size(203, 38);
            this.BtnGrafikler.TabIndex = 6;
            this.BtnGrafikler.Text = "Grafikler";
            this.BtnGrafikler.UseVisualStyleBackColor = true;
            this.BtnGrafikler.Click += new System.EventHandler(this.BtnGrafikler_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8_refresh_480px_2.png");
            this.ımageList1.Images.SetKeyName(1, "icons8_delete_240px_1.png");
            this.ımageList1.Images.SetKeyName(2, "icons8_tick_box_480px.png");
            this.ımageList1.Images.SetKeyName(3, "grafik.png");
            this.ımageList1.Images.SetKeyName(4, "51-514720_social-media-free-icon-pack-cleaner-broom-png.png");
            this.ımageList1.Images.SetKeyName(5, "pngtree-statistick-data-png-image_4431662.png");
            this.ımageList1.Images.SetKeyName(6, "png-clipart-computer-icons-icon-design-save-the-date-symbol-blue-angle-thumbnail." +
        "png");
            this.ımageList1.Images.SetKeyName(7, "icons8_cancel_480px_2.png");
            // 
            // Btnİstatistik
            // 
            this.Btnİstatistik.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btnİstatistik.ImageIndex = 5;
            this.Btnİstatistik.ImageList = this.ımageList1;
            this.Btnİstatistik.Location = new System.Drawing.Point(39, 196);
            this.Btnİstatistik.Margin = new System.Windows.Forms.Padding(4);
            this.Btnİstatistik.Name = "Btnİstatistik";
            this.Btnİstatistik.Size = new System.Drawing.Size(203, 38);
            this.Btnİstatistik.TabIndex = 5;
            this.Btnİstatistik.Text = "İstatistik";
            this.Btnİstatistik.UseVisualStyleBackColor = true;
            this.Btnİstatistik.Click += new System.EventHandler(this.Btnİstatistik_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnGuncelle.ImageIndex = 0;
            this.BtnGuncelle.ImageList = this.ımageList1;
            this.BtnGuncelle.Location = new System.Drawing.Point(39, 157);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(203, 38);
            this.BtnGuncelle.TabIndex = 3;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnSil.ImageIndex = 1;
            this.BtnSil.ImageList = this.ımageList1;
            this.BtnSil.Location = new System.Drawing.Point(39, 118);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(203, 38);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnKaydet.ImageIndex = 6;
            this.BtnKaydet.ImageList = this.ımageList1;
            this.BtnKaydet.Location = new System.Drawing.Point(39, 79);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(203, 38);
            this.BtnKaydet.TabIndex = 1;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnListele.ImageIndex = 2;
            this.BtnListele.ImageList = this.ımageList1;
            this.BtnListele.Location = new System.Drawing.Point(39, 40);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(203, 38);
            this.BtnListele.TabIndex = 0;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 327);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(853, 146);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 114);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(636, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackColor = System.Drawing.Color.White;
            this.BtnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnKapat.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnKapat.ImageIndex = 7;
            this.BtnKapat.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(734, 480);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(132, 39);
            this.BtnKapat.TabIndex = 33;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // FrmPersonelKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(876, 523);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPersonelKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Kayıt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGrafikler;
        private System.Windows.Forms.Button Btnİstatistik;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtMeslek;
        private System.Windows.Forms.TextBox TxtPersonelAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtPersonelid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.TextBox TxtMaas;
        private System.Windows.Forms.TextBox TxtSehir;
        private System.Windows.Forms.TextBox TxtDurum;
    }
}