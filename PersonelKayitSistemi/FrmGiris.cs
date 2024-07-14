using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonelKayitSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection bağlanti = new SqlConnection("Data Source=OKAN;Initial Catalog=PersonelKayit;Integrated Security=True");
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Yonetici where KullaniciAdi=@p1 and Sifre=@p2", bağlanti);
            komut.Parameters.AddWithValue("@p1", TxtKullanıcıAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Sisteme Başarılı Bir Şekilde Giriş Yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmPersonelKayıt fr = new FrmPersonelKayıt();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı & Şifre");
            }
            bağlanti.Close();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else if (checkBox1.CheckState==CheckState.Unchecked)
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }
    }
}
