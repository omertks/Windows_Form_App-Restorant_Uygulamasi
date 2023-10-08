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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Giris admingiris = new Admin_Giris();
            admingiris.Show();
            this.Hide();
           
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
                string Calisan_Giris_Sorgusu = "SELECT * from Calisanlar where Kullanici_Adi =@Kadi AND Sifre =@Sifre";
                SqlCommand cmd = new SqlCommand(Calisan_Giris_Sorgusu, con);
                cmd.Parameters.AddWithValue("@Kadi", KullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", Sifre);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Calisan_Sayfasi calisan_sayfa = new Calisan_Sayfasi();
                    calisan_sayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı! Lütfen Tekrar Deneyiniz.");

                }
            }

        }
    }
}
