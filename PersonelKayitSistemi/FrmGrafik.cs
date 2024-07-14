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
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        SqlConnection bağlanti=new SqlConnection("Data Source = OKAN; Initial Catalog = PersonelKayit; Integrated Security = True");
        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komutgr1 = new SqlCommand("Select PerSehir, Count(*) from Tbl_Personel group by Persehir ", bağlanti);
            SqlDataReader dr1 = komutgr1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            bağlanti.Close();

            bağlanti.Open();
            SqlCommand komutgr2 = new SqlCommand("Select PerMeslek, Avg(PerMaas) from Tbl_Personel group by PerMeslek", bağlanti);
            SqlDataReader dr2 = komutgr2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            bağlanti.Close();

        }
    }
}
