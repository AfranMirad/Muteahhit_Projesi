using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Müteahhit_Programı
{
    public partial class Toplam_Gider_Formu : Form
    {
        sınıfımız_F_A F_A = new sınıfımız_F_A();
        public Toplam_Gider_Formu()
        {
            InitializeComponent();
        }
        private void Toplam_Gider_Formu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Toplam_Gider_Formu_Load(object sender, EventArgs e)
        {
            F_A.toplam(dataGridView1,dataGridView2,dataGridView3);
        }

        private void btn_ana_Click(object sender, EventArgs e)
        {
            Insaat_Formu frm = new Insaat_Formu();
            frm.Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
