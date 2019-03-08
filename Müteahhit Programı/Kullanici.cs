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
    public partial class Kullanici_Formu : Form
    {
        sınıfımız_F_A F_A = new sınıfımız_F_A();

        public Kullanici_Formu()
        {
            InitializeComponent();
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            girisyap(txt_kullanici.Text,txt_sifre.Text);
        }
        public void girisyap(string aaaa, string bbbb)
        {
            F_A.baglantiac();
            try
            {
            OleDbCommand cmd = new OleDbCommand("SELECT kullanici,sifre FROM tbl_kullanici WHERE kullanici = '" + aaaa + "' AND sifre ='" + bbbb + "'", F_A.baglanti);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form aa = new Insaat_Formu();
                aa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış !!");
                Application.Restart();
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış !!");
                Application.Restart();
            }
        }
        private void Kullanici_Formu_Load(object sender, EventArgs e)
        {
            txt_kullanici.Text = "";
            txt_sifre.Text = "";
        }
        private void Kullanici_Formu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
