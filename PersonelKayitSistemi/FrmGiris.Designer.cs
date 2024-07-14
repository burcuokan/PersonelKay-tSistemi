namespace PersonelKayitSistemi
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnKapat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(234, 117);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(210, 26);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // TxtKullanıcıAdi
            // 
            this.TxtKullanıcıAdi.Location = new System.Drawing.Point(234, 81);
            this.TxtKullanıcıAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtKullanıcıAdi.Name = "TxtKullanıcıAdi";
            this.TxtKullanıcıAdi.Size = new System.Drawing.Size(211, 26);
            this.TxtKullanıcıAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.White;
            this.BtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGiris.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnGiris.ImageIndex = 2;
            this.BtnGiris.ImageList = this.ımageList1;
            this.BtnGiris.Location = new System.Drawing.Point(313, 195);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(132, 39);
            this.BtnGiris.TabIndex = 33;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8_contacts_208px_1.png");
            this.ımageList1.Images.SetKeyName(1, "icons8_keepass_512px.png");
            this.ımageList1.Images.SetKeyName(2, "onay.png");
            this.ımageList1.Images.SetKeyName(3, "icons8_close_512px.png");
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackColor = System.Drawing.Color.White;
            this.BtnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnKapat.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnKapat.ImageIndex = 3;
            this.BtnKapat.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(175, 195);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(132, 39);
            this.BtnKapat.TabIndex = 32;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox1.ImageList = this.ımageList1;
            this.checkBox1.Location = new System.Drawing.Point(234, 151);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 27);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(142, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(575, 263);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullanıcıAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtKullanıcıAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

