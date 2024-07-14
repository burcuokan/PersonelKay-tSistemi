namespace PersonelKayitSistemi
{
    partial class Frmİstatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmİstatistik));
            this.BtnKapat = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblToplamPersonelSayısı = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblEvliPersonelSayısı = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblBekarPersonelSayısı = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblSehirSayısı = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.LblToplamMaaş = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.LblOrtalamaMaaş = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackColor = System.Drawing.Color.White;
            this.BtnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnKapat.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnKapat.ImageIndex = 0;
            this.BtnKapat.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(506, 283);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(132, 39);
            this.BtnKapat.TabIndex = 34;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8_cancel_480px_2.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.LblToplamPersonelSayısı);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 120);
            this.panel1.TabIndex = 35;
            // 
            // LblToplamPersonelSayısı
            // 
            this.LblToplamPersonelSayısı.AutoSize = true;
            this.LblToplamPersonelSayısı.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamPersonelSayısı.Location = new System.Drawing.Point(22, 61);
            this.LblToplamPersonelSayısı.Name = "LblToplamPersonelSayısı";
            this.LblToplamPersonelSayısı.Size = new System.Drawing.Size(38, 45);
            this.LblToplamPersonelSayısı.TabIndex = 1;
            this.LblToplamPersonelSayısı.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Personel Sayısı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.LblEvliPersonelSayısı);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(226, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 120);
            this.panel2.TabIndex = 3;
            // 
            // LblEvliPersonelSayısı
            // 
            this.LblEvliPersonelSayısı.AutoSize = true;
            this.LblEvliPersonelSayısı.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEvliPersonelSayısı.Location = new System.Drawing.Point(22, 61);
            this.LblEvliPersonelSayısı.Name = "LblEvliPersonelSayısı";
            this.LblEvliPersonelSayısı.Size = new System.Drawing.Size(38, 45);
            this.LblEvliPersonelSayısı.TabIndex = 1;
            this.LblEvliPersonelSayısı.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(7, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Evli Personel Sayısı";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.panel5.Controls.Add(this.LblBekarPersonelSayısı);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(444, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 120);
            this.panel5.TabIndex = 36;
            // 
            // LblBekarPersonelSayısı
            // 
            this.LblBekarPersonelSayısı.AutoSize = true;
            this.LblBekarPersonelSayısı.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBekarPersonelSayısı.Location = new System.Drawing.Point(22, 61);
            this.LblBekarPersonelSayısı.Name = "LblBekarPersonelSayısı";
            this.LblBekarPersonelSayısı.Size = new System.Drawing.Size(38, 45);
            this.LblBekarPersonelSayısı.TabIndex = 1;
            this.LblBekarPersonelSayısı.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(7, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Bekar Personel Sayısı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.panel4.Controls.Add(this.LblSehirSayısı);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(12, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 120);
            this.panel4.TabIndex = 3;
            // 
            // LblSehirSayısı
            // 
            this.LblSehirSayısı.AutoSize = true;
            this.LblSehirSayısı.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSehirSayısı.Location = new System.Drawing.Point(22, 61);
            this.LblSehirSayısı.Name = "LblSehirSayısı";
            this.LblSehirSayısı.Size = new System.Drawing.Size(38, 45);
            this.LblSehirSayısı.TabIndex = 1;
            this.LblSehirSayısı.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(7, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Şehir Sayısı";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.panel9.Controls.Add(this.LblToplamMaaş);
            this.panel9.Controls.Add(this.label18);
            this.panel9.Location = new System.Drawing.Point(226, 147);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(194, 120);
            this.panel9.TabIndex = 5;
            // 
            // LblToplamMaaş
            // 
            this.LblToplamMaaş.AutoSize = true;
            this.LblToplamMaaş.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamMaaş.Location = new System.Drawing.Point(22, 61);
            this.LblToplamMaaş.Name = "LblToplamMaaş";
            this.LblToplamMaaş.Size = new System.Drawing.Size(38, 45);
            this.LblToplamMaaş.TabIndex = 1;
            this.LblToplamMaaş.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(7, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 23);
            this.label18.TabIndex = 0;
            this.label18.Text = "Toplam Maaş";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.panel11.Controls.Add(this.LblOrtalamaMaaş);
            this.panel11.Controls.Add(this.label22);
            this.panel11.Location = new System.Drawing.Point(444, 147);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(194, 120);
            this.panel11.TabIndex = 37;
            // 
            // LblOrtalamaMaaş
            // 
            this.LblOrtalamaMaaş.AutoSize = true;
            this.LblOrtalamaMaaş.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrtalamaMaaş.Location = new System.Drawing.Point(22, 61);
            this.LblOrtalamaMaaş.Name = "LblOrtalamaMaaş";
            this.LblOrtalamaMaaş.Size = new System.Drawing.Size(38, 45);
            this.LblOrtalamaMaaş.TabIndex = 1;
            this.LblOrtalamaMaaş.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(7, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(122, 23);
            this.label22.TabIndex = 0;
            this.label22.Text = "Ortalama Maaş";
            // 
            // Frmİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(646, 325);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnKapat);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frmİstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.Frmİstatistik_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblToplamPersonelSayısı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblEvliPersonelSayısı;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblBekarPersonelSayısı;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblSehirSayısı;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label LblToplamMaaş;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label LblOrtalamaMaaş;
        private System.Windows.Forms.Label label22;
    }
}