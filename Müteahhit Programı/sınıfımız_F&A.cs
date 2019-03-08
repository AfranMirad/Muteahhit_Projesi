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
    class sınıfımız_F_A
    {
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F&A.accdb");
        public DataSet ds = new DataSet();
        public DataTable tablo = new DataTable();
        public OleDbCommand komut = new OleDbCommand();
        public static int id=-1;
       public void baglantiac()
        {
            try
            {
                baglanti.Open();
            }
            catch (Exception)
            {
                baglanti.Close();
                baglanti.Open();
            }
        }
       //**********************İNŞAAT FORMU************************************************************************************************************
        public void YeniKayıt1(int idim,string ad, string adres, DateTime tarih)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Yeni kayıt yapmak istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    baglantiac();
                    komut.Connection = baglanti;
                    komut.CommandText = "INSERT INTO  tbl_insaat (insaat_adi,adres,tarih) VALUES (@adi,@adres,@tarih)";
                    komut.Parameters.AddWithValue("adi", ad);
                    komut.Parameters.AddWithValue("adres", adres);
                    komut.Parameters.AddWithValue("tarih", tarih);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayit Başarılı !");
                }
            }
            catch (Exception)
            {
            }
        }
        public void Goster1(DataGridView grid)
        {
            ds.Clear();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tbl_insaat", baglanti);
            adapter.Fill(ds, "tbl_insaat");
            grid.DataSource = ds.Tables[0];
        }
        public void VeriSil1(int id, DataGridView grid)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    baglantiac();
                    komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from tbl_insaat where id =" + id;
                    komut.ExecuteNonQuery();
                    Goster1(grid);
                    komut.Dispose();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden bir alan seçiniz.", "UYARI");
            }
        }
        public void VeriSil1_mal(int id)
        {
                    baglantiac();
                    komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from tbl_malzeme where id =" + id;
                    komut.ExecuteNonQuery();
                    komut.Dispose();
        }
         public void VeriSil1_cal(int id)
        {
                    baglantiac();
                    komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from tbl_calısan where id =" + id;
                    komut.ExecuteNonQuery();
                    komut.Dispose();
            }
        public void Düzenle1(int idim, string ad, string adres, DateTime tarih)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı düzenlemek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    baglantiac();
                    OleDbCommand komutguncelle = new OleDbCommand("UPDATE tbl_insaat SET insaat_adi='" + ad + "', adres ='" + adres + "', tarih ='" + tarih + "' WHERE id = " + idim, baglanti);
                    komutguncelle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Güncellendi !", "Kayıt Güncelleme!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden bir alan seçiniz.","UYARI");
            }
        }
        //*********************MALZEME FORMU***********************************************************************************************************
        public void YeniKayıt2(string ad, string alinan,string tel,string miktar,string fiyat, DateTime tarih)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Yeni kayıt yapmak istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    baglantiac();
                    komut.Connection = baglanti;
                    komut.CommandText = "INSERT INTO  tbl_malzeme (id,malz_adi,alinan,tel,miktar,fiyat,tarih) VALUES (@id,@adi,@alinan,@tel,@miktar,@fiyat,@tarih)";
                    komut.Parameters.AddWithValue("id", id);
                    komut.Parameters.AddWithValue("adi", ad);
                    komut.Parameters.AddWithValue("alinan", alinan);
                    komut.Parameters.AddWithValue("tel", tel);
                    komut.Parameters.AddWithValue("miktar", miktar);
                    komut.Parameters.AddWithValue("fiyat", fiyat);
                    komut.Parameters.AddWithValue("tarih", tarih);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayit Başarılı !");
                }
            }
            catch (Exception)
            {
            }
        }
        public void Goster2(DataGridView grid)
        {
            baglantiac();
            try
            {
                ds.Clear();
                komut = new OleDbCommand("Select * From tbl_malzeme where id =" + id, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    OleDbDataAdapter gel = new OleDbDataAdapter("Select malz_adi,alinan,tel,miktar,fiyat,tarih From tbl_malzeme where id =" + id, baglanti);
                    gel.Fill(ds, "tbl_malzeme");
                    grid.DataSource = ds.Tables[0];
                }
            }
            catch (Exception)
            {
                grid.DataSource = ds.Tables[0];
            }
        }
        public void VeriSil2(int id, DataGridView grid)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    baglantiac();
                    komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from tbl_malzeme where asil_id =" + id;
                    komut.ExecuteNonQuery();
                    Goster2(grid);
                    komut.Dispose();
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Lütfen listeden bir alan seçiniz.", "UYARI");
            }
        }
        public void Düzenle2(int idim, string ad, string alinan, string tel, string miktar, string fiyat, DateTime tarih)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı düzenlemek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {

                    baglantiac();
                    OleDbCommand komutguncelle = new OleDbCommand("UPDATE tbl_malzeme SET malz_adi='" + ad + "', alinan ='" + alinan + "', tel ='" + tel + "', miktar ='" + miktar + "', fiyat ='" + fiyat + "', tarih ='" + tarih + "' WHERE asil_id =" + idim, baglanti);
                    komutguncelle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Güncellendi !", "Kayıt Güncelleme!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden bir alan seçiniz.", "UYARI");
            }
        }
        //*********************ÇALIŞAN FORMU***********************************************************************************************************
        public void YeniKayıt3(string ad, string tel, string iş, string ödeme, DateTime tarih)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Yeni kayıt yapmak istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    baglantiac();
                    komut.Connection = baglanti;
                    komut.CommandText = "INSERT INTO  tbl_calısan (id,adi,tel,isin,ödeme,tarih) VALUES (@id,@adi,@tel,@isin,@ödeme,@tarih)";
                    komut.Parameters.AddWithValue("id", id);
                    komut.Parameters.AddWithValue("adi", ad);
                    komut.Parameters.AddWithValue("tel", tel);
                    komut.Parameters.AddWithValue("isin", iş);
                    komut.Parameters.AddWithValue("ödeme", ödeme);
                    komut.Parameters.AddWithValue("tarih", tarih);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayit Başarılı !");
                }
            }
            catch (Exception)
            {
            }
        }
        public void Goster3(DataGridView grid)
        {
            baglantiac();
            try
            {
                ds.Clear();
                komut = new OleDbCommand("Select * From tbl_calısan where id =" + id, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    OleDbDataAdapter gel = new OleDbDataAdapter("Select * From tbl_calısan where id =" + id, baglanti);
                    gel.Fill(ds, "tbl_calısan");
                    grid.DataSource = ds.Tables[0];
                }
            }
            catch (Exception)
            {
                grid.DataSource = ds.Tables[0];
            }
        }
        public void VeriSil3(int id, DataGridView grid)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    baglantiac();
                    komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from tbl_calısan where asil_id =" + id;
                    komut.ExecuteNonQuery();
                    Goster3(grid);
                    komut.Dispose();
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Lütfen listeden bir alan seçiniz.", "UYARI");
            }
        }
        public void Düzenle3(int idim, string ad, string tel,string iş,string ödeme, DateTime tarih)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı düzenlemek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    baglantiac();
                    OleDbCommand komutguncelle = new OleDbCommand("UPDATE tbl_calısan SET adi='" + ad + "', tel ='" + tel + "', isin ='" + iş + "', ödeme ='" + ödeme + "', tarih ='" + tarih + "' WHERE asil_id = " + idim, baglanti);
                    komutguncelle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Güncellendi !", "Kayıt Güncelleme!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden bir alan seçiniz.", "UYARI");
            }
        }
        //**********************KULLANICI FORMLARI*****************************************************************************************************
        public void yeni_kayıt(string ad,string sifre,string sifre2)
        {
            baglantiac();
            if (sifre==sifre2)
            {
                komut.Connection = baglanti;
                komut = new OleDbCommand("INSERT INTO tbl_kullanici (kullanici,sifre) VALUES (@ad,@sifre)", baglanti);
                komut.Parameters.AddWithValue("ad", ad);
                komut.Parameters.AddWithValue("sifre", sifre);
                komut.ExecuteNonQuery();
                MessageBox.Show("Yeni kullanıcı kaydı gerçekleştirildi.");
            }
            else
            {
                MessageBox.Show("lütfen şifrelerinizin aynı olduğuna dikkat ediniz");
            }
        }
        public void duzenle(string kadi, string sifre1, string sifre2, string eskikadi, string eskisifre)
        {
            baglantiac();
            if (sifre1 == sifre2 && kadi != "" && sifre1 != "" && sifre2 != "" && eskikadi != "" && eskisifre != "")
            {
                OleDbCommand komut = new OleDbCommand("UPDATE tbl_kullanici SET kullanici='" + kadi + "', sifre ='" + sifre1 + "' WHERE kullanici = '" + eskikadi + "' and sifre = '" + eskisifre + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme gerçekleştirildi.");
            }
            if (sifre1!=sifre2)
            {
                MessageBox.Show("Lütfen şifrelerin birbiri ile aynı olmasına dikkat ediniz.");
            }
            if (kadi=="" ||  sifre1=="" || sifre2=="" || eskikadi=="" || eskisifre=="")
            {
                MessageBox.Show("Lütfen alanları boş bırakmadığınızdan emin olunuz");
            }
        }
        //*********************TOPLAM GİDERLER *********************************************************************************************************
        public void toplam(DataGridView grid, DataGridView gridd,DataGridView griddd)
        {
            OleDbDataAdapter adaptor = new OleDbDataAdapter("select sum(ödeme) as Toplam_Çalışan from tbl_calısan group by id", baglanti);
            OleDbDataAdapter adaptor2 = new OleDbDataAdapter("select sum(fiyat) as Toplam_Malzeme from tbl_malzeme group by id", baglanti);
            OleDbDataAdapter adaptor3 = new OleDbDataAdapter("select id as İnsaat_Sıralaması ,insaat_adi as İnsaat_Adi from tbl_insaat", baglanti);
            DataTable tablo = new DataTable();
            DataTable tablo2 = new DataTable();
            DataTable tablo3 = new DataTable();
            adaptor.Fill(tablo);
            adaptor2.Fill(tablo2);
            adaptor3.Fill(tablo3);
            grid.DataSource = tablo;
            gridd.DataSource = tablo2;
            griddd.DataSource = tablo3;
        }
    }
}
