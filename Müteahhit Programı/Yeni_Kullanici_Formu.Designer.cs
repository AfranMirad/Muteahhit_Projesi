namespace Müteahhit_Programı
{
    partial class Yeni_Kullanici_Formu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yeni_Kullanici_Formu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_sifre2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_eskisifre = new System.Windows.Forms.TextBox();
            this.txt_eskikadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_duzen = new System.Windows.Forms.Button();
            this.btn_ana = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(303, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            this.label2.Visible = false;
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.Location = new System.Drawing.Point(99, 45);
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(100, 20);
            this.txt_kullanici.TabIndex = 3;
            this.txt_kullanici.Visible = false;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(99, 76);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 4;
            this.txt_sifre.Visible = false;
            // 
            // txt_sifre2
            // 
            this.txt_sifre2.Location = new System.Drawing.Point(99, 105);
            this.txt_sifre2.Name = "txt_sifre2";
            this.txt_sifre2.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre2.TabIndex = 6;
            this.txt_sifre2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre(Tekrar)";
            this.label3.Visible = false;
            // 
            // txt_eskisifre
            // 
            this.txt_eskisifre.Location = new System.Drawing.Point(99, 168);
            this.txt_eskisifre.Name = "txt_eskisifre";
            this.txt_eskisifre.Size = new System.Drawing.Size(100, 20);
            this.txt_eskisifre.TabIndex = 10;
            this.txt_eskisifre.Visible = false;
            // 
            // txt_eskikadi
            // 
            this.txt_eskikadi.Location = new System.Drawing.Point(99, 137);
            this.txt_eskikadi.Name = "txt_eskikadi";
            this.txt_eskikadi.Size = new System.Drawing.Size(100, 20);
            this.txt_eskikadi.TabIndex = 9;
            this.txt_eskikadi.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eski Şifre";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Eski Kullanıcı Adı";
            this.label5.Visible = false;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(210, 79);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Visible = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(210, 127);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Visible = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_duzen
            // 
            this.btn_duzen.Location = new System.Drawing.Point(210, 103);
            this.btn_duzen.Name = "btn_duzen";
            this.btn_duzen.Size = new System.Drawing.Size(75, 23);
            this.btn_duzen.TabIndex = 13;
            this.btn_duzen.Text = "Düzenle";
            this.btn_duzen.UseVisualStyleBackColor = true;
            this.btn_duzen.Visible = false;
            this.btn_duzen.Click += new System.EventHandler(this.btn_duzen_Click);
            // 
            // btn_ana
            // 
            this.btn_ana.Location = new System.Drawing.Point(210, 48);
            this.btn_ana.Name = "btn_ana";
            this.btn_ana.Size = new System.Drawing.Size(75, 23);
            this.btn_ana.TabIndex = 14;
            this.btn_ana.Text = "Ana sayfa";
            this.btn_ana.UseVisualStyleBackColor = true;
            this.btn_ana.Visible = false;
            this.btn_ana.Click += new System.EventHandler(this.btn_ana_Click);
            // 
            // Yeni_Kullanici_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(303, 207);
            this.Controls.Add(this.btn_ana);
            this.Controls.Add(this.btn_duzen);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_eskisifre);
            this.Controls.Add(this.txt_eskikadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sifre2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Yeni_Kullanici_Formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni_Kullanici_Formu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Yeni_Kullanici_Formu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kullanici;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_sifre2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_eskisifre;
        private System.Windows.Forms.TextBox txt_eskikadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_duzen;
        private System.Windows.Forms.Button btn_ana;


    }
}