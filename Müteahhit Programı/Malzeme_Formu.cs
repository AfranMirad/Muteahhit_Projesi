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
using System.Data;

namespace Müteahhit_Programı
{
    public partial class Malzeme_Formu : Form
    {
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F&A.accdb"); 
        public DataSet ds = new DataSet();
        sınıfımız_F_A F_A = new sınıfımız_F_A();

        public Malzeme_Formu()
        {
            InitializeComponent();
        }
        private void btn_malz_kaydet_Click(object sender, EventArgs e)
        {
            if (11 != txt_tel.TextLength)
            {
                MessageBox.Show("Telefon numarasının 11 haneli olmasına dikkat ediniz");
            }
            else
            {
                if (cmb_malz_adi.Text != "" && txt_alan_kisi.Text != "" && txt_tel.Text != "" && txt_miktar.Text != "" && txt_fiyat.Text != "" && dt_tarih.Text != "")
                {
                    F_A.YeniKayıt2(cmb_malz_adi.Text, txt_alan_kisi.Text, txt_tel.Text, txt_miktar.Text, txt_fiyat.Text, Convert.ToDateTime(dt_tarih.Text));
                    F_A.Goster2(dataGridView1);
                }
                else
                {
                    MessageBox.Show("Lütfen boş alan bırakmadığınızdan emin olunuz", "DİKKAT");
                }
            }
            temizle();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            int idim = dataGridView1.CurrentRow.Cells["asil_id"].Value.GetHashCode();
            F_A.VeriSil2(idim, dataGridView1);
            temizle();
        }
        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            int idim = dataGridView1.CurrentRow.Cells[0].Value.GetHashCode();
            F_A.Düzenle2(idim, cmb_malz_adi.Text, txt_alan_kisi.Text, txt_tel.Text, txt_miktar.Text, txt_fiyat.Text, Convert.ToDateTime(dt_tarih.Text));
            F_A.Goster2(dataGridView1);
            temizle();
        }
        private void Malzeme_Formu_Load(object sender, EventArgs e)
        {
            F_A.Goster2(dataGridView1);
        }

        private void Malzeme_Formu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();   
        }
        private void temizle()
        {
            txt_alan_kisi.Clear();
            txt_fiyat.Clear();
            txt_miktar.Clear();
            txt_tel.Clear();
        }
        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txt_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txt_malz_ara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_ara.SelectedItem.ToString() == "telefon numarasına göre" ||cmb_ara.SelectedItem.ToString() == "aldığı miktara göre"||cmb_ara.SelectedItem.ToString() == " fiyatına göre"||cmb_ara.SelectedItem.ToString() == "tarihe göre" )
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void txt_malz_ara_TextChanged(object sender, EventArgs e)
        {
            
            if (cmb_ara.SelectedItem.ToString() == "malzeme ismine göre")
            {
                F_A.baglantiac();
                ds.Clear();
                OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_malzeme WHERE malz_adi Like'%" + txt_malz_ara.Text + "%' and id=" + sınıfımız_F_A.id, baglanti);
                Ara.Fill(ds, "Tablolar");
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmb_ara.SelectedItem.ToString() == "malzemenin alınan kişiye göre")
            {
                F_A.baglantiac();
                ds.Clear();
                OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_malzeme WHERE alinan Like'%" + txt_malz_ara.Text + "%' and id=" + sınıfımız_F_A.id, baglanti);
                Ara.Fill(ds, "Tablolar");
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmb_ara.SelectedItem.ToString() == "telefon numarasına göre")
            {
                F_A.baglantiac();
                ds.Clear();
                OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_malzeme WHERE tel Like'%" + txt_malz_ara.Text + "%' and id=" + sınıfımız_F_A.id, baglanti);
                Ara.Fill(ds, "Tablolar");
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmb_ara.SelectedItem.ToString() == "aldığı miktara göre")
            {
                F_A.baglantiac();
                ds.Clear();
                OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_malzeme WHERE miktar Like'%" + txt_malz_ara.Text + "%' and id=" + sınıfımız_F_A.id, baglanti);
                Ara.Fill(ds, "Tablolar");
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmb_ara.SelectedItem.ToString() == " fiyatına göre")
            {
                F_A.baglantiac();
                ds.Clear();
                OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_malzeme WHERE fiyat Like'%" + txt_malz_ara.Text + "%' and id=" + sınıfımız_F_A.id, baglanti);
                Ara.Fill(ds, "Tablolar");
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmb_ara.SelectedItem.ToString() == "tarihe göre")
            {
                F_A.baglantiac();
                ds.Clear();
                OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_malzeme WHERE tarih Like'%" + txt_malz_ara.Text + "%' and id=" + sınıfımız_F_A.id, baglanti);
                Ara.Fill(ds, "Tablolar");
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmb_malz_adi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_alan_kisi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_tel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_miktar.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_fiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dt_tarih.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            temizle();
            this.Hide();
        }
    }
}
