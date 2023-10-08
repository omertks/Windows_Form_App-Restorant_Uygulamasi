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
    public partial class Calisan_Sayfasi : Form
    {
        public Calisan_Sayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oneri oneri = new Oneri();
            oneri.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calisan_Bilgi bilgi = new Calisan_Bilgi();
            bilgi.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
