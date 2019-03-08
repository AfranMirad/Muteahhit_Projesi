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
    public partial class Yeni_Kullanici_Formu : Form
    {
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F&A.accdb");
        public DataSet ds = new DataSet();
        public DataTable tablo = new DataTable();
        public OleDbCommand komut = new OleDbCommand();
        sınıfımız_F_A F_A = new sınıfımız_F_A();
        public Yeni_Kullanici_Formu()
        {
            InitializeComponent();
        }
        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txt_kullanici.Visible = true;
            txt_sifre.Visible = true;
            txt_sifre2.Visible = true;
            btn_kaydet.Visible = true;
            btn_sil.Visible = false;
            btn_duzen.Visible = false;
            txt_eskikadi.Visible = false;
            txt_eskisifre.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btn_ana.Visible = true;
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txt_kullanici.Visible = true;
            txt_sifre.Visible = true;
            txt_sifre2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txt_eskikadi.Visible = true;
            txt_eskisifre.Visible = true;
            btn_kaydet.Visible = false;
            btn_sil.Visible = false;
            btn_duzen.Visible = true;
            btn_ana.Visible = true;
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txt_kullanici.Visible = true;
            txt_sifre.Visible = true;
            txt_sifre2.Visible = true;
            btn_kaydet.Visible = false;
            btn_sil.Visible = true;
            btn_duzen.Visible = false;
            txt_eskikadi.Visible = false;
            txt_eskisifre.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btn_ana.Visible = true;
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            F_A.yeni_kayıt(txt_kullanici.Text,txt_sifre.Text,txt_sifre2.Text);
        }
        private void btn_ana_Click(object sender, EventArgs e)
        {
            Insaat_Formu frm = new Insaat_Formu();
            frm.Show();
            this.Hide();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            sil();
        }
        public void sil()
        {
            if (txt_sifre.Text == txt_sifre2.Text)
            {
                F_A.baglantiac();
                komut = new OleDbCommand("delete from tbl_kullanici where kullanici = '" + txt_kullanici.Text + "' and sifre = '" + txt_sifre.Text + "'", F_A.baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("silindi");
            }
            else
            {
                MessageBox.Show("lütfen şifrelerinizin aynı olduğuna dikkat ediniz");
            }
        }
        private void Yeni_Kullanici_Formu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btn_duzen_Click(object sender, EventArgs e)
        {
            F_A.duzenle(txt_kullanici.Text,txt_sifre.Text,txt_sifre2.Text,txt_eskikadi.Text,txt_eskisifre.Text);
            txt_eskikadi.Clear();
            txt_eskisifre.Clear();
            txt_kullanici.Clear();
            txt_sifre.Clear();
            txt_sifre2.Clear();
        }
    }
}
