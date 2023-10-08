using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Uygulamasi
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calisanlari_Yönet calisanlariyonet = new Calisanlari_Yönet();
            calisanlariyonet.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Onerileri_Goruntule_Admin goruntule = new Onerileri_Goruntule_Admin();
            goruntule.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fiyat_Liste fiyat = new Fiyat_Liste();
            fiyat.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            //this.Hide();

        }
    }
}
