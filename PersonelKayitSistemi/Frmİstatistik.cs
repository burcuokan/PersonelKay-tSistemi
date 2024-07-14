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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        SqlConnection bağlanti = new SqlConnection("Data Source=OKAN;Initial Catalog=PersonelKayit;Integrated Security=True");
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog=MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select Count(*) from Tbl_Personel", bağlanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamPersonelSayısı.Text = dr[0].ToString();
            }
            bağlanti.Close();

            bağlanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) from Tbl_Personel where PerDurum='Evli'", bağlanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvliPersonelSayısı.Text = dr2[0].ToString();
            }
            bağlanti.Close();

            bağlanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) from Tbl_Personel where PerDurum='Bekar'", bağlanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblBekarPersonelSayısı.Text = dr3[0].ToString();
            }
            bağlanti.Close();

            bağlanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) from Tbl_Personel", bağlanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblSehirSayısı.Text = dr4[0].ToString();
            }
            bağlanti.Close();

            bağlanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) from Tbl_Personel", bağlanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblToplamMaaş.Text = dr5[0].ToString();
            }
            bağlanti.Close();

            bağlanti.Open();
            SqlCommand komu6 = new SqlCommand("Select Avg(PerMaas) from Tbl_Personel", bağlanti);
            SqlDataReader dr6 = komu6.ExecuteReader();
            while (dr6.Read())
            {
                LblOrtalamaMaaş.Text = dr6[0].ToString();
            }
            bağlanti.Close();
        }
    }
}
