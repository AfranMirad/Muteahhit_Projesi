using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Müteahhit_Programı
{
    public partial class Insaat_Formu : Form
    {
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F&A.accdb"); 
        public DataSet ds = new DataSet();
        sınıfımız_F_A F_A = new sınıfımız_F_A();

        public Insaat_Formu()
        {
            InitializeComponent();
        }
        private void Insaat_Formu_Load(object sender, EventArgs e)
        {
            F_A.Goster1(dataGridView1);
            temizle();
        }
        private void btn_ins_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_ins_adi.Text != "" && rtxt_ins_adres.Text != "" && dt_tarih.Text != "")
            {
                int idim = dataGridView1.CurrentRow.Cells[0].Value.GetHashCode();
                F_A.YeniKayıt1(idim, txt_ins_adi.Text, rtxt_ins_adres.Text, Convert.ToDateTime(dt_tarih.Text));
                F_A.Goster1(dataGridView1);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmadığınızdan emin olunuz", "DİKKAT"); 
            }
           
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.CurrentRow.Cells["id"].Value.GetHashCode();
            F_A.VeriSil1(id, dataGridView1);
            F_A.VeriSil1_mal(id);
            F_A.VeriSil1_cal(id);
            temizle();
        }
        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            int idim = dataGridView1.CurrentRow.Cells[0].Value.GetHashCode();
            F_A.Düzenle1(idim, txt_ins_adi.Text, rtxt_ins_adres.Text, Convert.ToDateTime(dt_tarih.Text));
            F_A.Goster1(dataGridView1);
            temizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sınıfımız_F_A.id = dataGridView1.CurrentRow.Cells[0].Value.GetHashCode();
            txt_ins_adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            rtxt_ins_adres.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dt_tarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void txt_ins_ara_TextChanged(object sender, EventArgs e)
        {
                if (cmb_ara.SelectedItem.ToString()=="İnşaat ismine göre")
                {
                    F_A.baglantiac();
                    ds.Clear();
                    OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_insaat WHERE insaat_adi Like'%" + txt_ins_ara.Text + "%'", baglanti);
                    Ara.Fill(ds, "Tablolar");
                    dataGridView1.DataSource = ds.Tables[0];
                }
                if (cmb_ara.SelectedItem.ToString() == "İnşaatın adresine göre")
                {
                    F_A.baglantiac();
                    ds.Clear();
                    OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_insaat WHERE adres Like'%" + txt_ins_ara.Text + "%'", baglanti);
                    Ara.Fill(ds, "Tablolar");
                    dataGridView1.DataSource = ds.Tables[0];
                }
                if (cmb_ara.SelectedItem.ToString() == "Başlangıç tarihine göre")
                {
                    F_A.baglantiac();
                    ds.Clear();
                    OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_insaat WHERE tarih Like'%" + txt_ins_ara.Text + "%'", baglanti);
                    Ara.Fill(ds, "Tablolar");
                    dataGridView1.DataSource = ds.Tables[0];
                }
        }
        private void btn_calısan_Click(object sender, EventArgs e)
        {
            temizle();
            try
            {
                this.Hide();
                Calısan_Formu frm = new Calısan_Formu();
                frm.ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden bir kaydı seçiniz.", "UYARI ");
            }
        }
        private void btn_malzeme_Click(object sender, EventArgs e)
        {
            temizle();
            try
            {
                this.Hide();
                Malzeme_Formu frm = new Malzeme_Formu();
                frm.ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden bir kaydı seçiniz.", "UYARI ");
            }
        }
        private void Insaat_Formu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void temizle()
        {
            txt_ins_adi.Clear();
            rtxt_ins_adres.Clear();
        }
        private void btn_yenik_Click(object sender, EventArgs e)
        {
            Yeni_Kullanici_Formu frm = new Yeni_Kullanici_Formu();
            frm.Show();
            this.Hide();
        }
        private void btn_toplam_Click(object sender, EventArgs e)
        {
            Toplam_Gider_Formu frm = new Toplam_Gider_Formu();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
