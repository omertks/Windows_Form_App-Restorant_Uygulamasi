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
    public partial class Admin_Giris : Form
    {

        
        public Admin_Giris()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = richTextBox1.Text;
            string Sifre = richTextBox2.Text;
            SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");

            if (KullaniciAdi == "" || Sifre == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
            }
            else
            {
                con.Open();
                string Calisan_Giris_Sorgusu = "SELECT * from Admin where Kullanici_adi =@Kadi AND Sifre =@Sifre";
                SqlCommand cmd = new SqlCommand(Calisan_Giris_Sorgusu, con);
                cmd.Parameters.AddWithValue("@Kadi", KullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", Sifre);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı! Lütfen Tekrar Deneyiniz.");

                }
            }
        }

        private void Admin_Giris_Load(object sender, EventArgs e)
        {
            
        }

            private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sifemi_Unuttum sifre_degistir = new Sifemi_Unuttum();
            sifre_degistir.Show();
            this.Hide();
        }
    }
}
