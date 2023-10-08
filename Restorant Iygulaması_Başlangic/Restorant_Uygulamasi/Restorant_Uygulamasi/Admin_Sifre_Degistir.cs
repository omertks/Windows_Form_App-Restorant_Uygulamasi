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
    public partial class Admin_Sifre_Degistir : Form
    {
        public Admin_Sifre_Degistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre1 = richTextBox1.Text;
            string sifre2 = richTextBox2.Text;
            string Yeni_Guvenlik_Sorusu = richTextBox3.Text;
            string Yeni_Guvenlik_Sorusu_Cevabı = richTextBox4.Text;
            if (sifre1 == sifre2 && Yeni_Guvenlik_Sorusu!="" && Yeni_Guvenlik_Sorusu_Cevabı!="")
            {

                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Yeni_Sifre = "Update Admin Set Sifre=@sifre,Guvenlik_Sorusu=@soru,Guvenlik_Sorusu_Cevap=@cevap where id=1";
                SqlCommand cmd=new SqlCommand(Yeni_Sifre, con);
                cmd.Parameters.AddWithValue("@sifre", sifre1);
                cmd.Parameters.AddWithValue("@soru",Yeni_Guvenlik_Sorusu);
                cmd.Parameters.AddWithValue("@cevap",Yeni_Guvenlik_Sorusu_Cevabı);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Şifreniz Ve Sorunuz Hazırlanmıştır!");
                con.Close();
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen girdiğiniz şifrelerin eşleştiğinden emin olun ve tüm alanları doldurun!");
            }
        }
    }
}
