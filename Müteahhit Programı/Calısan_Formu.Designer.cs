namespace Müteahhit_Programı
{
    partial class Calısan_Formu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calısan_Formu));
            this.cmb_is = new System.Windows.Forms.ComboBox();
            this.txt_ödeme = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ara = new System.Windows.Forms.ComboBox();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_calısan_kaydet = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_calısan_ara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_tarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_is
            // 
            this.cmb_is.FormattingEnabled = true;
            this.cmb_is.Items.AddRange(new object[] {
            "Fayans",
            "Boya",
            "Sıva",
            "Alçı",
            "Duvar",
            "Kalıp",
            "Merdiven",
            "Doğrama",
            "Çelik kapı",
            "Tesisat",
            "Elektrik",
            "Çatı",
            "Yıkım",
            "Taşıma"});
            this.cmb_is.Location = new System.Drawing.Point(83, 270);
            this.cmb_is.Name = "cmb_is";
            this.cmb_is.Size = new System.Drawing.Size(100, 21);
            this.cmb_is.TabIndex = 81;
            // 
            // txt_ödeme
            // 
            this.txt_ödeme.Location = new System.Drawing.Point(83, 297);
            this.txt_ödeme.Name = "txt_ödeme";
            this.txt_ödeme.Size = new System.Drawing.Size(100, 20);
            this.txt_ödeme.TabIndex = 80;
            this.txt_ödeme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ödeme_KeyPress);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(83, 245);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 79;
            this.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_KeyPress);
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(83, 219);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_adi.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Ödeme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "İş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Adı";
            // 
            // cmb_ara
            // 
            this.cmb_ara.FormattingEnabled = true;
            this.cmb_ara.Items.AddRange(new object[] {
            "ada göre",
            "tele göre",
            "işe göre",
            "fiyata göre",
            "tarihe göre"});
            this.cmb_ara.Location = new System.Drawing.Point(289, 274);
            this.cmb_ara.Name = "cmb_ara";
            this.cmb_ara.Size = new System.Drawing.Size(100, 21);
            this.cmb_ara.TabIndex = 72;
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(113, 12);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(95, 25);
            this.btn_duzenle.TabIndex = 71;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(214, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(95, 25);
            this.btn_sil.TabIndex = 70;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_calısan_kaydet
            // 
            this.btn_calısan_kaydet.Location = new System.Drawing.Point(12, 12);
            this.btn_calısan_kaydet.Name = "btn_calısan_kaydet";
            this.btn_calısan_kaydet.Size = new System.Drawing.Size(95, 25);
            this.btn_calısan_kaydet.TabIndex = 69;
            this.btn_calısan_kaydet.Text = "Kaydet";
            this.btn_calısan_kaydet.UseVisualStyleBackColor = true;
            this.btn_calısan_kaydet.Click += new System.EventHandler(this.btn_malz_kaydet_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Location = new System.Drawing.Point(315, 12);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(95, 25);
            this.btn_anasayfa.TabIndex = 68;
            this.btn_anasayfa.Text = "Ana Sayfa";
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 170);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // txt_calısan_ara
            // 
            this.txt_calısan_ara.Location = new System.Drawing.Point(289, 301);
            this.txt_calısan_ara.Name = "txt_calısan_ara";
            this.txt_calısan_ara.Size = new System.Drawing.Size(100, 20);
            this.txt_calısan_ara.TabIndex = 83;
            this.txt_calısan_ara.TextChanged += new System.EventHandler(this.txt_calısan_ara_TextChanged);
            this.txt_calısan_ara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_calısan_ara_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 52);
            this.label7.TabIndex = 84;
            this.label7.Text = "Aşağıda arama yapmak\r\nistediğiniz bölümü seçip\r\naltındakikutuya sözcüğü \r\ngiriniz" +
    ".\r\n";
            // 
            // dt_tarih
            // 
            this.dt_tarih.Location = new System.Drawing.Point(83, 323);
            this.dt_tarih.Name = "dt_tarih";
            this.dt_tarih.Size = new System.Drawing.Size(170, 20);
            this.dt_tarih.TabIndex = 85;
            // 
            // Calısan_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(423, 355);
            this.Controls.Add(this.dt_tarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_calısan_ara);
            this.Controls.Add(this.cmb_is);
            this.Controls.Add(this.txt_ödeme);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ara);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_calısan_kaydet);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calısan_Formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışanlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calısan_Formu_FormClosed);
            this.Load += new System.EventHandler(this.Calısan_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_is;
        private System.Windows.Forms.TextBox txt_ödeme;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ara;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_calısan_kaydet;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_calısan_ara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_tarih;
    }
}