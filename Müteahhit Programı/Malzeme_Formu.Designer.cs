namespace Müteahhit_Programı
{
    partial class Malzeme_Formu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Malzeme_Formu));
            this.cmb_malz_adi = new System.Windows.Forms.ComboBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_alan_kisi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ara = new System.Windows.Forms.ComboBox();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_malz_kaydet = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_malz_ara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_tarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_malz_adi
            // 
            this.cmb_malz_adi.FormattingEnabled = true;
            this.cmb_malz_adi.Items.AddRange(new object[] {
            "Mermer",
            "Seramik",
            "Alçı",
            "Pimapen",
            "Boya",
            "Boru",
            "Elektrik",
            "Kapı",
            "Çatı",
            "Mutfak-Banyo",
            "Tuğla-Ytong",
            "Çimento",
            "Çivi",
            "Şiş",
            "Kum"});
            this.cmb_malz_adi.Location = new System.Drawing.Point(102, 264);
            this.cmb_malz_adi.Name = "cmb_malz_adi";
            this.cmb_malz_adi.Size = new System.Drawing.Size(100, 21);
            this.cmb_malz_adi.TabIndex = 64;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(358, 294);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(100, 20);
            this.txt_fiyat.TabIndex = 63;
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fiyat_KeyPress);
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(358, 268);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(100, 20);
            this.txt_miktar.TabIndex = 62;
            this.txt_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_miktar_KeyPress);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(102, 317);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 61;
            this.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_KeyPress);
            // 
            // txt_alan_kisi
            // 
            this.txt_alan_kisi.Location = new System.Drawing.Point(102, 291);
            this.txt_alan_kisi.Name = "txt_alan_kisi";
            this.txt_alan_kisi.Size = new System.Drawing.Size(100, 20);
            this.txt_alan_kisi.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Alınan Kişi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "MalzemeAdı";
            // 
            // cmb_ara
            // 
            this.cmb_ara.FormattingEnabled = true;
            this.cmb_ara.Items.AddRange(new object[] {
            "malzeme ismine göre",
            "malzemenin alınan kişiye göre",
            "telefon numarasına göre",
            "aldığı miktara göre",
            "fiyatına göre",
            "tarihe göre"});
            this.cmb_ara.Location = new System.Drawing.Point(243, 353);
            this.cmb_ara.Name = "cmb_ara";
            this.cmb_ara.Size = new System.Drawing.Size(100, 21);
            this.cmb_ara.TabIndex = 53;
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(93, 12);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(77, 23);
            this.btn_duzenle.TabIndex = 52;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(176, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(76, 23);
            this.btn_sil.TabIndex = 51;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_malz_kaydet
            // 
            this.btn_malz_kaydet.Location = new System.Drawing.Point(12, 12);
            this.btn_malz_kaydet.Name = "btn_malz_kaydet";
            this.btn_malz_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_malz_kaydet.TabIndex = 50;
            this.btn_malz_kaydet.Text = "Kaydet";
            this.btn_malz_kaydet.UseVisualStyleBackColor = true;
            this.btn_malz_kaydet.Click += new System.EventHandler(this.btn_malz_kaydet_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Location = new System.Drawing.Point(258, 12);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(77, 23);
            this.btn_anasayfa.TabIndex = 49;
            this.btn_anasayfa.Text = "Ana Sayfa";
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 212);
            this.dataGridView1.TabIndex = 48;
            // 
            // txt_malz_ara
            // 
            this.txt_malz_ara.Location = new System.Drawing.Point(358, 354);
            this.txt_malz_ara.Name = "txt_malz_ara";
            this.txt_malz_ara.Size = new System.Drawing.Size(100, 20);
            this.txt_malz_ara.TabIndex = 66;
            this.txt_malz_ara.TextChanged += new System.EventHandler(this.txt_malz_ara_TextChanged);
            this.txt_malz_ara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_malz_ara_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 26);
            this.label7.TabIndex = 67;
            this.label7.Text = "Arama yapmak istediğiniz bölümü\r\n seçip altındakikutuya sözcüğü giriniz.\r\n";
            // 
            // dt_tarih
            // 
            this.dt_tarih.Location = new System.Drawing.Point(288, 322);
            this.dt_tarih.Name = "dt_tarih";
            this.dt_tarih.Size = new System.Drawing.Size(170, 20);
            this.dt_tarih.TabIndex = 68;
            // 
            // Malzeme_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(471, 388);
            this.Controls.Add(this.dt_tarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_malz_ara);
            this.Controls.Add(this.cmb_malz_adi);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_alan_kisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ara);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_malz_kaydet);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Malzeme_Formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzemeler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Malzeme_Formu_FormClosed);
            this.Load += new System.EventHandler(this.Malzeme_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_malz_adi;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_alan_kisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ara;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_malz_kaydet;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_malz_ara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_tarih;
        private System.Windows.Forms.TextBox txt_miktar;
    }
}