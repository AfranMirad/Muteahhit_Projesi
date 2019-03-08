namespace Müteahhit_Programı
{
    partial class Insaat_Formu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insaat_Formu));
            this.dt_tarih = new System.Windows.Forms.DateTimePicker();
            this.btn_calısan = new System.Windows.Forms.Button();
            this.btn_malzeme = new System.Windows.Forms.Button();
            this.cmb_ara = new System.Windows.Forms.ComboBox();
            this.txt_ins_ara = new System.Windows.Forms.TextBox();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ins_kaydet = new System.Windows.Forms.Button();
            this.rtxt_ins_adres = new System.Windows.Forms.RichTextBox();
            this.txt_ins_adi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_yenik = new System.Windows.Forms.Button();
            this.btn_toplam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_tarih
            // 
            this.dt_tarih.Location = new System.Drawing.Point(158, 312);
            this.dt_tarih.Name = "dt_tarih";
            this.dt_tarih.Size = new System.Drawing.Size(209, 20);
            this.dt_tarih.TabIndex = 39;
            // 
            // btn_calısan
            // 
            this.btn_calısan.Location = new System.Drawing.Point(384, 333);
            this.btn_calısan.Name = "btn_calısan";
            this.btn_calısan.Size = new System.Drawing.Size(92, 23);
            this.btn_calısan.TabIndex = 38;
            this.btn_calısan.Text = "Çalışan";
            this.btn_calısan.UseVisualStyleBackColor = true;
            this.btn_calısan.Click += new System.EventHandler(this.btn_calısan_Click);
            // 
            // btn_malzeme
            // 
            this.btn_malzeme.Location = new System.Drawing.Point(384, 362);
            this.btn_malzeme.Name = "btn_malzeme";
            this.btn_malzeme.Size = new System.Drawing.Size(92, 23);
            this.btn_malzeme.TabIndex = 37;
            this.btn_malzeme.Text = "Malzeme";
            this.btn_malzeme.UseVisualStyleBackColor = true;
            this.btn_malzeme.Click += new System.EventHandler(this.btn_malzeme_Click);
            // 
            // cmb_ara
            // 
            this.cmb_ara.FormattingEnabled = true;
            this.cmb_ara.Items.AddRange(new object[] {
            "İnşaat ismine göre",
            "İnşaatın adresine göre",
            "Başlangıç tarihine göre"});
            this.cmb_ara.Location = new System.Drawing.Point(158, 362);
            this.cmb_ara.Name = "cmb_ara";
            this.cmb_ara.Size = new System.Drawing.Size(209, 21);
            this.cmb_ara.TabIndex = 36;
            // 
            // txt_ins_ara
            // 
            this.txt_ins_ara.Location = new System.Drawing.Point(158, 392);
            this.txt_ins_ara.Name = "txt_ins_ara";
            this.txt_ins_ara.Size = new System.Drawing.Size(209, 20);
            this.txt_ins_ara.TabIndex = 35;
            this.txt_ins_ara.TextChanged += new System.EventHandler(this.txt_ins_ara_TextChanged);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(384, 275);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(92, 23);
            this.btn_duzenle.TabIndex = 34;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(384, 304);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(92, 23);
            this.btn_sil.TabIndex = 33;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ins_kaydet
            // 
            this.btn_ins_kaydet.Location = new System.Drawing.Point(384, 246);
            this.btn_ins_kaydet.Name = "btn_ins_kaydet";
            this.btn_ins_kaydet.Size = new System.Drawing.Size(92, 23);
            this.btn_ins_kaydet.TabIndex = 32;
            this.btn_ins_kaydet.Text = "Kaydet";
            this.btn_ins_kaydet.UseVisualStyleBackColor = true;
            this.btn_ins_kaydet.Click += new System.EventHandler(this.btn_ins_kaydet_Click);
            // 
            // rtxt_ins_adres
            // 
            this.rtxt_ins_adres.Location = new System.Drawing.Point(158, 279);
            this.rtxt_ins_adres.Name = "rtxt_ins_adres";
            this.rtxt_ins_adres.Size = new System.Drawing.Size(209, 24);
            this.rtxt_ins_adres.TabIndex = 31;
            this.rtxt_ins_adres.Text = "";
            // 
            // txt_ins_adi
            // 
            this.txt_ins_adi.Location = new System.Drawing.Point(158, 253);
            this.txt_ins_adi.Name = "txt_ins_adi";
            this.txt_ins_adi.Size = new System.Drawing.Size(209, 20);
            this.txt_ins_adi.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "İnşaat Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 223);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 39);
            this.label4.TabIndex = 40;
            this.label4.Text = "Arama yapmak istediğiniz \r\nbölümü seçip altındaki\r\nkutuya sözcüğü giriniz.\r\n";
            // 
            // btn_yenik
            // 
            this.btn_yenik.Location = new System.Drawing.Point(384, 391);
            this.btn_yenik.Name = "btn_yenik";
            this.btn_yenik.Size = new System.Drawing.Size(92, 23);
            this.btn_yenik.TabIndex = 41;
            this.btn_yenik.Text = "Yeni Kullanıcı";
            this.btn_yenik.UseVisualStyleBackColor = true;
            this.btn_yenik.Click += new System.EventHandler(this.btn_yenik_Click);
            // 
            // btn_toplam
            // 
            this.btn_toplam.Location = new System.Drawing.Point(384, 420);
            this.btn_toplam.Name = "btn_toplam";
            this.btn_toplam.Size = new System.Drawing.Size(92, 23);
            this.btn_toplam.TabIndex = 42;
            this.btn_toplam.Text = "Toplam Giderler";
            this.btn_toplam.UseVisualStyleBackColor = true;
            this.btn_toplam.Click += new System.EventHandler(this.btn_toplam_Click);
            // 
            // Insaat_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(496, 476);
            this.Controls.Add(this.btn_toplam);
            this.Controls.Add(this.btn_yenik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_tarih);
            this.Controls.Add(this.btn_calısan);
            this.Controls.Add(this.btn_malzeme);
            this.Controls.Add(this.cmb_ara);
            this.Controls.Add(this.txt_ins_ara);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ins_kaydet);
            this.Controls.Add(this.rtxt_ins_adres);
            this.Controls.Add(this.txt_ins_adi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Insaat_Formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İnşaat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Insaat_Formu_FormClosed);
            this.Load += new System.EventHandler(this.Insaat_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_tarih;
        private System.Windows.Forms.Button btn_calısan;
        private System.Windows.Forms.Button btn_malzeme;
        private System.Windows.Forms.ComboBox cmb_ara;
        private System.Windows.Forms.TextBox txt_ins_ara;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ins_kaydet;
        private System.Windows.Forms.RichTextBox rtxt_ins_adres;
        private System.Windows.Forms.TextBox txt_ins_adi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_yenik;
        private System.Windows.Forms.Button btn_toplam;
    }
}