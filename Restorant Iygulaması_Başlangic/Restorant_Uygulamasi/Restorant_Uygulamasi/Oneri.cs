using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Restorant_Uygulamasi
{
    public partial class Oneri : Form
    {
        public Oneri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && richTextBox2.Text != "")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Ekle = "Insert Into Oneriler (Konu,Aciklama,Tarih) Values (@konu,@aciklama,@tarih)";
                SqlCommand cmd = new SqlCommand(Ekle, con);
                cmd.Parameters.AddWithValue("@konu", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@aciklama", richTextBox2.Text);
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Öneriniz Yöneticinize Bildirilmiştir!");
                con.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calisan_Sayfasi calisan_sayfa = new Calisan_Sayfasi();
            calisan_sayfa.Show();
            this.Hide();
        }
    }
}
