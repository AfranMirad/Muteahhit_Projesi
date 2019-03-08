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
    public partial class Calısan_Formu : Form
    {
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F&A.accdb"); 
        public DataSet ds = new DataSet();

        sınıfımız_F_A F_A = new sınıfımız_F_A();

        public Calısan_Formu()
        {
            InitializeComponent();
        }

        private void Calısan_Formu_Load(object sender, EventArgs e)
        {
            F_A.Goster3(dataGridView1);
        }
        private void btn_malz_kaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txt_adi.Text != "" && txt_tel.Text != "" && cmb_is.Text != "" && txt_ödeme.Text != "" && dt_tarih.Text != "")
                {
                    F_A.YeniKayıt3(txt_adi.Text, txt_tel.Text, cmb_is.Text, txt_ödeme.Text, Convert.ToDateTime(dt_tarih.Text));
                    F_A.Goster3(dataGridView1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen boş alan bırakmadığınızdan emin olunuz", "DİKKAT");
            }
            temizle();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            int idim = dataGridView1.CurrentRow.Cells["asil_id"].Value.GetHashCode();
            F_A.VeriSil3(idim, dataGridView1);
            temizle();
        }
        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            int idim = dataGridView1.CurrentRow.Cells[0].Value.GetHashCode();
            F_A.Düzenle3(idim, txt_adi.Text, txt_tel.Text, cmb_is.Text, txt_ödeme.Text, Convert.ToDateTime(dt_tarih.Text));
            F_A.Goster3(dataGridView1);
            temizle();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            temizle();
            this.Hide();
        }
        private void Calısan_Formu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
        private void temizle()
        {
            txt_adi.Clear();
            txt_ödeme.Clear();
            txt_tel.Clear();
        }
        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txt_ödeme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txt_calısan_ara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_ara.SelectedItem.ToString() == "tele göre"||cmb_ara.SelectedItem.ToString() == "fiyata göre"||cmb_ara.SelectedItem.ToString() == "tarihe göre")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void txt_calısan_ara_TextChanged(object sender, EventArgs e)
        {
            if (cmb_ara.SelectedItem.ToString() == "ada göre")
            {
                F_A.baglantiac();
                ds.Clear();
                OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_calısan WHERE adi Like'%" + txt_calısan_ara.Text + "%' and id=" + sınıfımız_F_A.id, baglanti);
                Ara.Fill(ds, "Tablolar");
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmb_ara.SelectedItem.ToString() == "tele göre")
            {
                F_A.baglantiac();
                ds.Clear();
                OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_calısan WHERE tel Like'%" + txt_calısan_ara.Text + "%' and id=" + sınıfımız_F_A.id, baglanti);
                Ara.Fill(ds, "Tablolar");
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmb_ara.SelectedItem.ToString() == "fiyata göre")
            {
                F_A.baglantiac();
                ds.Clear();
                OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_calısan WHERE isin Like'%" + txt_calısan_ara.Text + "%' and id=" + sınıfımız_F_A.id, baglanti);
                Ara.Fill(ds, "Tablolar");
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmb_ara.SelectedItem.ToString() == "işe göre")
            {
                F_A.baglantiac();
                ds.Clear();
                OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_calısan WHERE ödeme Like'%" + txt_calısan_ara.Text + "%' and id=" + sınıfımız_F_A.id, baglanti);
                Ara.Fill(ds, "Tablolar");
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (cmb_ara.SelectedItem.ToString() == "tarihe göre")
            {
                F_A.baglantiac();
                ds.Clear();
                OleDbDataAdapter Ara = new OleDbDataAdapter("SELECT * FROM tbl_calısan WHERE tarih Like'%" + txt_calısan_ara.Text + "%' and id=" + sınıfımız_F_A.id, baglanti);
                Ara.Fill(ds, "Tablolar");
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_adi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_tel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmb_is.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_ödeme.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dt_tarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
