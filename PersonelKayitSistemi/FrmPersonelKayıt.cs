using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayitSistemi
{
    public partial class FrmPersonelKayıt : Form
    {
        public FrmPersonelKayıt()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_PersonelTableAdapter dt = new DataSet1TableAdapters.Tbl_PersonelTableAdapter();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.PersonelListesi();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Bu kişiyi kaydetmek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                dt.PersonelKaydet(TxtPersonelAd.Text, TxtSoyad.Text, TxtSehir.Text, int.Parse(TxtMaas.Text), TxtMeslek.Text, TxtDurum.Text);
                MessageBox.Show("Personel Sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("BU personeli silmek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                dt.PersonelSil(int.Parse(TxtPersonelid.Text));
                MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Bu personeli güncellemek istediğinizden emin misiniz?", "Soru Pencresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog==DialogResult.Yes)
            {
                dt.PersonelGuncelle(TxtPersonelAd.Text, TxtSoyad.Text, TxtSehir.Text, int.Parse(TxtMaas.Text), TxtDurum.Text, TxtMeslek.Text, int.Parse(TxtPersonelid.Text));
                MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Btnİstatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr = new Frmİstatistik();
            fr.Show();
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafik fr = new FrmGrafik();
            fr.Show();
        }
    }
}

